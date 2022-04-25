using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismProject.Domain.Enums
{
    public enum RefListProvince:int
    {
        [Description("1.Gauteng")]
        Gauteng=1,

        [Description("2.Limpopo")]
        Limpopo=2,

        [Description("3.Mpumalanga")]
        Mpumalanga=3,

        [Description("4.KwaZulu-Natal")]
        KwaZuluNatal=4,

        [Description("5.Eastern Cape")]
        EasternCape=5,

        [Description("6.Free State")]
        FreeState=6,

        [Description("7.Northern Cape")]
        NorthernCape=7,

        [Description("8.North West")]
        NorthWest=8,

        [Description("9.Western Cape")]
        WesternCape=9


    }
}
