namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EmployeeTask : BaseEntity
    {
        [Required]
        public virtual Employee Assignee { get; set; }

        [Required]
        public virtual Area Area { get; set; }

        public string Subject { get; set; }

        public string Actions { get; set; }

        public EmployeeTaskStatus Status { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ActualEndDate { get; set; }

        public double Progress { get; set; }       
    }
}
