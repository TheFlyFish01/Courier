using System.Threading.Tasks;
using MyAbpStudy.Configuration.Dto;

namespace MyAbpStudy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
