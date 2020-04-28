using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpStudy.CourierCompanys
{
    public class CourierCompanyEntity : Entity, IHasCreationTime
    {
        public long? CourierId { get; set; }
        public string CourierName { get; set; }
        public string CourierPeople { get; set; }
        
        [MaxLength(11)]
        public long PhoneNumber { get; set; }
        public Double Money { get; set; }
        public DateTime CreationTime { get; set; }
        public CourierCompanyEntity() 
        {
            CreationTime = Clock.Now;
        }

    }
}
