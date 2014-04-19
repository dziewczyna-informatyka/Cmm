using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess
{
    public enum EmploymentType
    {
        [Display(ResourceType = typeof(Common), Name = "EmploymentType_Clinico")]
        Clinico = 0,

        [Display(ResourceType = typeof(Common), Name = "EmploymentType_Manpower")]
        Manpower = 1
    }
}
