using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismProject.Domain.Enums
{
   public enum RefListRole: int
    {
        [Description("1. Manager")]
        Manager=1,

        [Description("1. Tour Guard")]
        TourGuard=2,

        [Description("1. Admin")]
        Admin=3
    }
}
