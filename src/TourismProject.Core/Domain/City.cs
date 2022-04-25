using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain.Discriminators;

namespace TourismProject.Domain
{
    [Entity(TypeShortAlias = "Tour.City")]
    public class City: FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual Province? Province { get; set; }
    
    }
}
