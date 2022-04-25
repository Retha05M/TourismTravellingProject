using Abp.Application.Services;
using TourismProject.MultiTenancy.Dto;

namespace TourismProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

