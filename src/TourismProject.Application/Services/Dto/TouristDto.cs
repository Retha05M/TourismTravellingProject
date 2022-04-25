using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain;

namespace TourismProject.Services.Dto
{
    [AutoMapFrom(typeof(Tourist))]
    public class TouristDto : PersonDto
    {
        public DateTime BookingDate { get; set; }

        public Guid? PriceId { get; set; }

        public Guid? AttractionId { get; set; }

    }
}
