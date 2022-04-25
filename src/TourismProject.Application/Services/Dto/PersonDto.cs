using Abp.Application.Services.Dto;
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
    [AutoMapFrom(typeof(Person))]
    public class PersonDto : EntityDto<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public RefListGender Gender { get; set; }

        public string IdentificationNumber { get; set; }

        public string CellPhoneNumber { get; set; }

        public string Email { get; set; }

    }
}
