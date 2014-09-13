namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MaintenanceManagement.Core;

    public class EmployeeTask : BaseEntity
    {
        [Required]
        public Employee Assignee { get; set; }

        [Required]
        public Area Area { get; set; }

        public string Subject { get; set; }

        public string Actions { get; set; }

        public EmployeeTaskStatus Status { get; set; }

        public string StatusName
        {
            get { return this.Status.EnumToString(); }
        }

        public DateTime DueDate { get; set; }

        public string DueDateText
        {
            get { return this.DueDate.ToShortDateString(); }
        }

        public bool IsDueDateWarning
        {
            get { return this.Status != EmployeeTaskStatus.Done && !this.IsDueDateError && this.DueDate.Subtract(DateTime.Now).TotalDays < 5; }
        }

        public bool IsDueDateError
        {
            get { return this.Status != EmployeeTaskStatus.Done && this.DueDate.Subtract(DateTime.Now).TotalDays <= 0; }
        }

        public bool IsDone
        {
            get { return this.Status == EmployeeTaskStatus.Done; }
        }

        public bool IsNotStarted
        {
            get { return this.Status == EmployeeTaskStatus.InProgress && this.Progress == 0; }
        }

        public bool IsPerformed
        {
            get { return this.Status == EmployeeTaskStatus.InProgress && this.Progress > 0 && this.Progress < 60; }
        }

        public DateTime? ActualEndDate { get; set; }

        public string ActualEndDateText
        {
            get { return this.ActualEndDate != null && this.Status == EmployeeTaskStatus.Done ? this.ActualEndDate.Value.ToShortDateString() : string.Empty; }
        }

        public string DaysRemaining
        {
            get
            {
                return this.Status != EmployeeTaskStatus.Done
                    ? Math.Floor(this.DueDate.Subtract(DateTime.Now).TotalDays).ToString()
                    : string.Empty;
            }
        }

        public double Progress { get; set; }

        public string AssigneeName
        {
            get
            {
                return this.Assignee != null ? this.Assignee.FullName(this.Assignee) : string.Empty;
            }
        }

        public string AreaName
        {
            get { return Area == null ? string.Empty : Area.Name; }
        }
    }
}
