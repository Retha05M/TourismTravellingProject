using System.Collections.Generic;
using TourismProject.Roles.Dto;

namespace TourismProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
