using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TourismProject.Configuration.Dto;

namespace TourismProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TourismProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
