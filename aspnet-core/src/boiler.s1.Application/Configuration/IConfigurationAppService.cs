using System.Threading.Tasks;
using boiler.s1.Configuration.Dto;

namespace boiler.s1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
