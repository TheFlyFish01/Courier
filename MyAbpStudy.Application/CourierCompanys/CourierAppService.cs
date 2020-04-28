using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using MyAbpStudy.CourierCompanys.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpStudy.CourierCompanys
{
    [AbpAuthorize]

    public class CourierAppServices : ApplicationService
    {
        public TEntity MapToEntity<TEntity>(EntityDto input) where TEntity : Entity
        {
            return ObjectMapper.Map<TEntity>(input);
        }

        private readonly IRepository<CourierCompanyEntity> _repository;
        public CourierAppServices(
            IRepository<CourierCompanyEntity> repository)
        {
            _repository = repository;
        }
        public async Task CreatCourierAsync(CreatCourierInput inputDto)
        {
            var exist = await _repository.CountAsync(t => t.CourierName == inputDto.CourierName) > 0;
            if (exist)
            {
                throw new UserFriendlyException("该公司已经存在");
            }
            var company = MapToEntity<CourierCompanyEntity>(inputDto);
            //var company = ObjectMapper.Map<CourierCompanyEntity>(inputDto);
            //company = new CourierCompanyEntity { CourierName = inputDto.CourierName, CourierPeople = inputDto.CourierPeople, PhoneNumber = inputDto.PhoneNumber };
            _repository.Insert(company);
        }
    }
    //".../Courier/CreatCourier"
    [AbpAuthorize]
    public class CourierAppService : ApplicationService
    {
        private readonly IRepository<CourierCompanyEntity> _repository;
        public CourierAppService(IRepository<CourierCompanyEntity> repository)
        {
            _repository = repository;
        }

        public void CreatCourierTest(int id)
        {
            int v = id;
        }
        public void CreatCourierTest1(string courierName,string courierPeople,long phoneNumber,double money,int id)
        {
            //var exist = _repository.Count(t => t.CourierName == input.CourierName) > 0;
            //if (exist)
            //{
            //    throw new UserFriendlyException("该公司已经存在");
            //}
            //var company = ObjectMapper.Map<CourierCompanyEntity>(input);
            //_repository.Insert(company);
        }
        public async Task CreatCourierAsync(CreatCourierInput input)
        {
            var exist = await _repository.CountAsync(t => t.CourierName == input.CourierName) > 0;
            if (exist)
            {
                throw new UserFriendlyException("该公司已经存在");
            }
            var company = ObjectMapper.Map<CourierCompanyEntity>(input);
            //company = new CourierCompanyEntity { CourierName = input.CourierName, CourierPeople = input.CourierPeople, PhoneNumber = input.PhoneNumber };
            _repository.Insert(company);
        }
        public EasyUIPagedResultDto<CreatCourierOutput> GetAll()
        {
            var returnlist = _repository.GetAll();
            var tasks = ObjectMapper.Map<List<CreatCourierOutput>>(returnlist.ToList());
            var list = _repository.GetAllList();
            var dtolist = list.Select(MapToDto).ToList();

            return new EasyUIPagedResultDto<CreatCourierOutput> { total = dtolist.Count(),rows = dtolist };
        }
        protected virtual CreatCourierOutput MapToDto(CourierCompanyEntity entity)
        {
            return ObjectMapper.Map<CreatCourierOutput>(entity);
        }

    }
}
