using Abp.Authorization;
using TourismProject.Authorization.Roles;
using TourismProject.Authorization.Users;

namespace TourismProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
