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
    [AutoMapFrom(typeof(Attraction))]
    public class AttractionDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public Guid? City { get; set; }
    }
}
