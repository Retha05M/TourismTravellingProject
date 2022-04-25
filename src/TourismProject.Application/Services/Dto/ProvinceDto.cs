using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain.Enums;
using TourismProject.Domain;

namespace TourismProject.Services.Dto
{
    [AutoMapFrom(typeof(Province))]
    public class ProvinceDto : EntityDto<Guid>

    {
        public string Name { get; set; }
        public RefListProvince Number { get; set; }

    }
}
