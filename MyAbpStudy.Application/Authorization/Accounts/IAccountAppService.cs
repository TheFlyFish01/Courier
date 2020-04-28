using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpStudy.Authorization.Accounts.Dto;

namespace MyAbpStudy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
