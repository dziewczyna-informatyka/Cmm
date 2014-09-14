namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MaintenanceManagement.Core.Resources;

    public class EmployeeTask : BaseEntity
    {
        [Required]
        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_Assignee")]
        public virtual Employee Assignee { get; set; }

        [Required]
        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_Area")]
        public virtual Area Area { get; set; }

        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_Subject")]
        public string Subject { get; set; }

        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_Actions")]
        public string Actions { get; set; }

        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_Status")]
        public EmployeeTaskStatus Status { get; set; }

        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_DueDate")]
        public DateTime DueDate { get; set; }

        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_ActualEndDate")]
        public DateTime? ActualEndDate { get; set; }

        [Display(ResourceType = typeof(Common), Name = "EmployeeTask_Progress")]
        public double Progress { get; set; }
    }
}
