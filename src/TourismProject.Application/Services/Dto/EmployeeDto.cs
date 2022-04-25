using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismProject.Domain;
using TourismProject.Domain.Enums;

namespace TourismProject.Services.Dto
{
    [AutoMapFrom(typeof(Employee))]
    public class EmployeeDto : PersonDto
    {
        public string EmployeeNumber { get; set; }
        public DateTime StartDate { get; set; }
        public RefListRole Role { get; set; }
        public Guid? Tourist { get; set; }
    }
}
