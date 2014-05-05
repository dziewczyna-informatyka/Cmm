using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess
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
