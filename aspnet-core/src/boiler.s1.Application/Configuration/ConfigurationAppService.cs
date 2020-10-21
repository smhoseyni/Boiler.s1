using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using boiler.s1.Configuration.Dto;

namespace boiler.s1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : s1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
