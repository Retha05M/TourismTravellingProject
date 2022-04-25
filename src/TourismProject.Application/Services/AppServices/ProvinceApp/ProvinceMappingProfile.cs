using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain;
using TourismProject.Services.Dto;

namespace TourismProject.Services.AppServices.ProvinceApp
{
    public class ProvinceMappingProfile: Profile
    {
        public ProvinceMappingProfile()
        {
            CreateMap<ProvinceDto, Province>();
            
        }
    }
}
