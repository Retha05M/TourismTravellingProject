using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain;

namespace TourismProject.Services.Dto
{

    [AutoMapFrom(typeof(City))]
    public class CityDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public Guid? ProvinceId { get; set; }

    }
}
