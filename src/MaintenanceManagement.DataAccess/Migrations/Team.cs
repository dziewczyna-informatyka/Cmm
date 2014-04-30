using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess.Migrations
{
    public enum Team
    {
        [Display(ResourceType = typeof(Common), Name = "Team_A")]
        A = 0,

        [Display(ResourceType = typeof(Common), Name = "Team_B")]
        B = 1,

        [Display(ResourceType = typeof(Common), Name = "Team_C")]
        C = 2,

        [Display(ResourceType = typeof(Common), Name = "Team_D")]
        D = 3,
    }
}
