using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain;
using TourismProject.Services.Dto;

namespace TourismProject.Services.AppServices.CityApp
{
    public class CityMappingProfile: Profile
    {
        public CityMappingProfile()
        {
            CreateMap<City, CityDto>()
                .ForMember(provinceTable => provinceTable.ProvinceId, cityData => cityData.MapFrom(provinceTable => provinceTable.Province != null ? provinceTable.Province.Id : (Guid?)null));

            CreateMap<CityDto, City>()
              .ForMember(provinceTable => provinceTable.Id, d => d.Ignore());
        }
    }
}
