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
    [AutoMapFrom(typeof(Price))]
    public class PriceDto : EntityDto<Guid>
    {
        public int Amount { get; set; }

        public Guid? AttractionId { get; set; }
    }
}
