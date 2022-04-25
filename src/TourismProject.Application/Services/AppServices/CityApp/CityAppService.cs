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

namespace TourismProject.Services.AppServices.CityApp
{
    public class CityAppService : ApplicationService, ICityAppService
    {
        private readonly IRepository<City, Guid> _cityRepository;
        private readonly IRepository<Province, Guid> _province;
        public CityAppService(IRepository<City, Guid> cityRepository, IRepository<Province, Guid> province)
        {

            _cityRepository = cityRepository;
            _province = province;
        }

        public async Task<CityDto> CreateAsync(CityDto input)
        {
            var city = ObjectMapper.Map<City>(input);
            city.Province = await _province.GetAsync((Guid)input.ProvinceId);
            await _cityRepository.InsertAsync(city); 
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<CityDto>(city);
        }

        public async Task DeleteAsync(Guid id)
        {
            var city = await _cityRepository.GetAsync((Guid)id);
            await _cityRepository.DeleteAsync(city);
            CurrentUnitOfWork.SaveChanges();
        }

        public async Task<PagedResultDto<CityDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<CityDto>> GetAsync(PagedAndSortedResultRequestDto input, Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<CityDto> UpdateAsync(CityDto input)
        {
            var city = ObjectMapper.Map<City>(input);
            city.Province = await _province.GetAsync((Guid)input.ProvinceId);
            await _cityRepository.UpdateAsync(city);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<CityDto>(city);
        }
    }
}
