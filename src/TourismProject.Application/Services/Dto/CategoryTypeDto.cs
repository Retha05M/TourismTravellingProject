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
    [AutoMapFrom(typeof(CategoryType))]
    public class CategoryTypeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public Guid? AttractionId { get; set; }
    }
}
