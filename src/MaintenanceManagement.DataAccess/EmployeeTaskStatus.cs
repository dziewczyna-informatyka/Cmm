using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess
{
    public enum EmployeeTaskStatus
    {
        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_Suggestion")]
        Suggestion = 0,

        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_InProgress")]
        InProgress = 1,

        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_Done")]
        Done = 2,

        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_Canceled")]
        Canceled = 3,

        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_Planned")]
        Planned = 4
    }
}