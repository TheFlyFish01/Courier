/*********************************************************
 * 开发人员：Hobin
 * 创建时间：2017-08-16
 * 描述说明：实体转数据库
 * 更改历史：浮点精度、忽略表名转换，忽略字段名转换，版本号。
 * 20170907：Hobin 处理Discriminator属性报错，原因无PropertyInfo。
 * 20170907：Hobin 处理指定表名无大写转换。
 * 20170907：Hobin 处理指定外键名无大写转换。
 * 20170907：Hobin 处理字段名多次转换。
 * 存在问题：字符串长度如何处理默认
 * *******************************************************/
using Abp;
using Abp.Application.Features;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.DynamicEntityParameters;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace MyAbpStudy.EntityFrameworkCore
{
    public static class ModelBuilderExtensions
    {
        public const string ProPre = "P_";
        public const string FunPre = "F_";
        public const string ViewPre = "V_";
        public const string TablePre = "T_";
        public const string FieldPre = "F_";
        /// <summary>
        /// 转表名
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="preserveAcronyms"></param>
        /// <returns></returns>
        public static string ToTableName(this string tableName, bool preserveAcronyms = true)
        {
            if (tableName.StartsWith(TablePre, StringComparison.CurrentCultureIgnoreCase)) return tableName.ToUpper();
            if (tableName.StartsWith(ViewPre, StringComparison.CurrentCultureIgnoreCase)) return tableName.ToUpper();
            return TablePre + StringHelper.ToTableName(tableName, preserveAcronyms);
        }
        /// <summary>
        /// 转字段名
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="preserveAcronyms"></param>
        /// <returns></returns>
        public static string ToFieldName(this string fieldName, bool preserveAcronyms = true)
        {
            if (fieldName.StartsWith(FieldPre, StringComparison.CurrentCultureIgnoreCase)) return fieldName.ToUpper();
            return FieldPre + StringHelper.ToFieldName(fieldName, preserveAcronyms);
        }
        /// <summary>
        /// 转外键字段名
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="preserveAcronyms"></param>
        /// <returns></returns>
        public static string ToForeignKeyFieldName(this string tableName, bool preserveAcronyms = true)
        {
            if (tableName.StartsWith(FieldPre, StringComparison.CurrentCultureIgnoreCase)) return tableName.ToUpper();
            return FieldPre + StringHelper.ToTableName(tableName, preserveAcronyms);
        }
        private static List<Type> IgnoreTableNames
        {
            get
            {
                return new List<Type>()
                {
                    typeof(EntityDynamicParameterValue),
                    typeof(EntityDynamicParameter),
                    typeof(EditionFeatureSetting),
                    typeof(RolePermissionSetting),
                    typeof(UserPermissionSetting),
                    typeof(TenantFeatureSetting)
                };
            }
        }
        /// <summary>
        /// 对entity进行数据库转换的规则
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <param name="preserveAcronyms"></param>
        public static void SetSimpleUnderscoreTableNameConvention(this ModelBuilder modelBuilder, bool preserveAcronyms = true)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                bool ignoreTableMap = IgnoreTableNames.Contains(entity.ClrType);
                if (!ignoreTableMap)
                {
                    var tableName = entity.GetTableName();
                    if (!tableName.Contains(ViewPre) && !tableName.Contains(TablePre))
                    {
                        entity.SetTableName(tableName.ToTableName(preserveAcronyms));
                    }
                }
                foreach (IMutableProperty prop in entity.GetProperties())
                {
                    //外键
                    if (prop.IsForeignKey())
                    {
                        prop.SetColumnName(prop.GetColumnName().ToForeignKeyFieldName(preserveAcronyms));
                    }
                    else if (prop.PropertyInfo == null)
                    {
                        prop.SetColumnName(prop.GetColumnName().ToFieldName(preserveAcronyms));
                    }
                    else
                    {
                        //ColumnAttribute指定则不处理列名
                        var column = prop.PropertyInfo.GetCustomAttributes<ColumnAttribute>(true).FirstOrDefault();
                        if (column == null)
                            prop.SetColumnName(prop.GetColumnName().ToFieldName(preserveAcronyms));
                        else
                            prop.SetColumnName(column.Name.ToFieldName(preserveAcronyms));
                        //处理并发
                        if (prop.GetColumnName().Equals(FieldPre + "VERSION")) prop.IsConcurrencyToken = true;
                        ////无法判定需要max的属性,所以取消设定默认值
                        //if (prop.ClrType.Equals(typeof(String)) && prop.PropertyInfo.GetCustomAttribute<MaxLengthAttribute>(true) == null && prop.PropertyInfo.GetCustomAttribute<StringLengthAttribute>(true) == null)
                        //{
                        //    prop.SetMaxLength(80);
                        //}
                    }
                }
            }
        }
    }
}
