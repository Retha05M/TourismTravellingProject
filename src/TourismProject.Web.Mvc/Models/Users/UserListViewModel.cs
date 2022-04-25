using System.Collections.Generic;
using TourismProject.Roles.Dto;

namespace TourismProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
