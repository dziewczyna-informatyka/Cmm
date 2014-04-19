using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess
{
    public enum JobTitle
    {
        [Display(ResourceType = typeof(Common), Name = "JobTitle_Mechanic")]
        Mechanic = 0,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Shift_Leader")]
        ShiftLeader = 1,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Area_Leader")]
        AreaLeader = 2,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Workshop_Worker")]
        WorkshopWorker = 3,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Facility_Worker")]
        FacilityWorker = 4,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Electrician")]
        Electrician = 5,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Controlling_Worker")]
        ControllingWorker = 6,

        [Display(ResourceType = typeof(Common), Name = "JobTitle_Manager")]
        Manager = 7
    }
}
