using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Services.Dto;

namespace TourismProject.Services.AppServices.ProvinceApp
{
    public interface IProvinceAppService: IAsyncCrudAppService<ProvinceDto,Guid, PagedAndSortedResultRequestDto>
    {

    }
}
