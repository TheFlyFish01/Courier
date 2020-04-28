using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAbpStudy.CourierCompanys.Dtos
{
    public class CreatCourierInput:EntityDto
    {
        [Required]

        [DisplayName("快递公司")]
        public virtual string CourierName { get; set; }
        [DisplayName("负责人")]
        public virtual string CourierPeople { get; set; }
        [DisplayName("联系方式")]
        public virtual long PhoneNumber { get; set; }
        [DisplayName("寄放费")]
        public virtual Double Money { get; set; }

    
    }
    public class CreatCourierOutput : CreatCourierInput
    {
        [DisplayName("创建时间")]
        public virtual DateTime CreationTime { get; set; }
    }
    public class CourierProfile: Profile
    {
       public CourierProfile()
        {
            CreateMap<CourierCompanyEntity, CreatCourierOutput>();
            CreateMap<CreatCourierInput, CourierCompanyEntity>()
                .ForMember(target => target.CourierId, map => map.Ignore())
                //.ForMember(target => target.PhoneNumber, map => map.MapFrom(t=>t.CourierName))
                .ForMember(target => target.CreationTime, map => map.Ignore());
        }
    }
}
