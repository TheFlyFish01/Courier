using System;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Abp
{
    /// <summary>
    /// String辅助类
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// 给大写字母前添加下划线
        /// </summary>
        /// <param name="text"></param>
        /// <param name="preserveAcronyms">处理连续大写</param>
        /// <returns></returns>
        public static string AddUndercores(string text, bool preserveAcronyms = true)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            var newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != '_' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append('_');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }
        /// <summary>
        /// 类名转换，忽略ENTITY
        /// </summary>
        /// <param name="classname"></param>
        /// <param name="preserveAcronyms"></param>
        /// <returns></returns>
        public static string ToTableName(string classname, bool preserveAcronyms = true)
        {
            var tname = AddUndercores(classname, preserveAcronyms);
            return tname.ToUpper().Replace("_ENTITYS", "").Replace("_ENTITY", "").Replace("_ENTITIES", "");
        }
        /// <summary>
        /// 属性名转字段名
        /// </summary>
        /// <param name="propname"></param>
        /// <param name="preserveAcronyms"></param>
        /// <returns></returns>
        public static string ToFieldName(string propname, bool preserveAcronyms = true)
        {
            var tname = AddUndercores(propname, preserveAcronyms);
            return tname.ToUpper();
        }
        public static string LowerFirst(string s)
        {
            return Regex.Replace(s, @"\b[A-Z]\w+", delegate (Match match)
            {
                string v = match.ToString();
                return char.ToLower(v[0]) + v.Substring(1);
            });
        }
        
        /// <summary>
        /// 获取对象或属性的名称
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="expr">选择对象的表达式</param>
        /// <param name="initialLoweCase">首字母是否小写</param>
        /// <returns>对象或属性名称的字符串</returns>
        public static string GetPropertyName<T>(Expression<Func<T, object>> expr, bool initialLoweCase)
        {
            var result = GetPropertyName(expr);
            if (initialLoweCase && (!string.IsNullOrEmpty(result)))
            {
                return result.First().ToString().ToLower() + result.Substring(1);
            }
            return result;
        }
        /// <summary>
        /// 获取对象或属性的名称
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="expr">选择对象的表达式</param>
        /// <returns>对象或属性名称的字符串</returns>
        public static string GetPropertyName<T>(Expression<Func<T, object>> expr)
        {
            var rtn = "";
            if (expr.Body is UnaryExpression)
            {
                rtn = ((MemberExpression)((UnaryExpression)expr.Body).Operand).Member.Name;
            }
            else if (expr.Body is MemberExpression)
            {
                rtn = ((MemberExpression)expr.Body).Member.Name;
            }
            else if (expr.Body is ParameterExpression)
            {
                rtn = ((ParameterExpression)expr.Body).Type.Name;
            }
            return rtn;
        }
        /// <summary>
        /// 解析url字符串中的参数
        /// </summary>
        /// <param name="url">url字符串</param>
        /// <returns>参数集合</returns>
        public static NameValueCollection ParseUrl(string url)
        {
            return ParseUrl(url, out string baseUrl);
        }
        /// <summary>
        /// 解析url字符串
        /// </summary>
        /// <param name="url">url字符串</param>
        /// <param name="baseUrl">去除url字符中参数的部分</param>
        /// <returns>参数集合</returns>
        public static NameValueCollection ParseUrl(string url, out string baseUrl)
        {
            if (string.IsNullOrEmpty(url))
            {
                baseUrl = "";
                throw new ArgumentNullException("url");
            }
            NameValueCollection nvc = new NameValueCollection();
            int quIdxTmp = url.IndexOf('?');
            if (quIdxTmp == -1)
            {
                url = "?" + url;
            }
            int quIdx = url.IndexOf('?');
            if (quIdx == -1)
            {
                baseUrl = url;
                return null;
            }
            baseUrl = url.Substring(0, quIdx);
            if (quIdx == url.Length - 1)
            {
                return null;
            }
            string ps = url.Substring(quIdx + 1);
            // 开始分析参数对    
            Regex re = new Regex(@"(^|&)?(\w+)=([^&]*)(&|$)?", RegexOptions.Compiled);
            MatchCollection mc = re.Matches(ps);
            foreach (Match m in mc)
            {
                nvc.Add(m.Result("$2"), m.Result("$3"));
            }
            return nvc;
        }
    }
}
