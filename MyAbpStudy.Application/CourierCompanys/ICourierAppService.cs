using Abp.Application.Services;
using MyAbpStudy.CourierCompanys.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAbpStudy.CourierCompanys
{
    public interface ICourierAppService:IApplicationService
    {
        void CreatCourier(CreatCourierInput input);

    }
}
