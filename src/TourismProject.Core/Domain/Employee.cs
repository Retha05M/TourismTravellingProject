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
    [Entity(TypeShortAlias="Tour.Employee")]
    [DiscriminatorValue("Tour.Employee")]
   public class Employee: Person
    {
        public virtual string EmployeeNumber { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual RefListRole Role { get; set; }
        public virtual Tourist Tourist { get; set; }
    }
}
