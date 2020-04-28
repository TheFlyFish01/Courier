using Abp.Application.Services;
using MyAbpStudy.MultiTenancy.Dto;

namespace MyAbpStudy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

