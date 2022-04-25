using System.Collections.Generic;
using TourismProject.Roles.Dto;

namespace TourismProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}