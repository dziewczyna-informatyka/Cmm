namespace MaintenanceManagement.DataAccess
{
    using System.ComponentModel.DataAnnotations;

    using MaintenanceManagement.Core.Resources;

    public enum WorkSchedule
    {
        [Display(ResourceType = typeof(Common), Name = "WorkSchedule_Regular")]
        Regular = 0,

        [Display(ResourceType = typeof(Common), Name = "WorkSchedule_TwoShifts")]
        TwoShifts = 1,

        [Display(ResourceType = typeof(Common), Name = "WorkSchedule_Continuous")]
        Continuous = 2
    }
}