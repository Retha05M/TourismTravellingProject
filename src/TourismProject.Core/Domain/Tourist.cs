using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain.Discriminators;

namespace TourismProject.Domain
{
    [Entity(TypeShortAlias = "Tour.Tourist")]
    [DiscriminatorValue("Tour.Tourist")]
    public class Tourist: Person
    {
        public virtual DateTime BookingDate { get; set; }

        public virtual Price Price { get; set; }

        public virtual Attraction Attraction { get; set; }

    }
}
