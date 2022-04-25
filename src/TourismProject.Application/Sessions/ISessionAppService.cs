using System.Threading.Tasks;
using Abp.Application.Services;
using TourismProject.Sessions.Dto;

namespace TourismProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
