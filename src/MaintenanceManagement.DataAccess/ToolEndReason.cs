using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess
{
    public enum ToolEndReason
    {
        [Display(ResourceType = typeof(Common), Name = "ToolEndReason_Damage")]
        Damage = 0,

        [Display(ResourceType = typeof(Common), Name = "ToolEndReason_Exchange")]
        Exchange = 1,
    }
}