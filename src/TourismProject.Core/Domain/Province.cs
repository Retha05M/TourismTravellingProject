using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain.Discriminators;
using TourismProject.Domain.Enums;

namespace TourismProject.Domain
{
    [Entity(TypeShortAlias = "Tour.Province")]
    public class Province: FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual RefListProvince Number { get; set; }
    }
}
