using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain.Discriminators;

namespace TourismProject.Domain
{
    [Entity(TypeShortAlias = "Tour.Price")]
    public class Price: FullAuditedEntity<Guid>
    {
        public virtual int Amount { get; set; }

        public virtual Attraction Attraction { get; set; }
    }
}
