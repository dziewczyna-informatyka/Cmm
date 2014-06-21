using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess
{
    public enum EmployeeTaskStatus
    {
        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_InProgress")]
        InProgress = 2,

        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_Done")]
        Done = 3,

        [Display(ResourceType = typeof(Common), Name = "EmployeeTaskStatus_Planned")]
        Planned = 1
    }
}