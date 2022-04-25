using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain;
using TourismProject.Services.Dto;

namespace TourismProject.Services.AppServices.ProvinceApp
{
    public class ProvinceAppService : AsyncCrudAppService<Province,ProvinceDto,Guid, PagedAndSortedResultRequestDto>,IProvinceAppService
    {
        private readonly IRepository<Province, Guid> _repository;
        public ProvinceAppService(IRepository<Province,Guid> repository):base(repository)
        {
            _repository = repository;

        }

    }
}
