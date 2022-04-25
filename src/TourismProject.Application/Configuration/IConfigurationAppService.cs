using System.Threading.Tasks;
using TourismProject.Configuration.Dto;

namespace TourismProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
