namespace MaintenanceManagement.DataAccess
{
    using System.ComponentModel.DataAnnotations;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.Core.Resources;

    public enum Team
    {
        [Display(ResourceType = typeof(Common), Name = "Team_NA")]
        NA = 6,

        [Display(ResourceType = typeof(Common), Name = "Team_A")]
        A = 0,

        [Display(ResourceType = typeof(Common), Name = "Team_B")]
        B = 1,

        [Display(ResourceType = typeof(Common), Name = "Team_C")]
        C = 2,

        [Display(ResourceType = typeof(Common), Name = "Team_D")]
        D = 3,

        [Display(ResourceType = typeof(Common), Name = "Team_Infrastructure")]
        Infrastruktura = 4,

        [Display(ResourceType = typeof(Common), Name = "Team_Workshop")]
        Warsztat = 5,
    }
}
