using System;
using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess.Entities
{
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
            get { return Status.EnumToString(); }
        }

        public DateTime DueDate { get; set; }

        public string DueDateText
        {
            get { return DueDate.ToShortDateString(); }
        }

        public bool IsDueDateWarning
        {
            get { return Status != EmployeeTaskStatus.Done && !IsDueDateError && DueDate.Subtract(DateTime.Now).TotalDays < 5; }
        }

        public bool IsDueDateError
        {
            get { return Status != EmployeeTaskStatus.Done && DueDate.Subtract(DateTime.Now).TotalDays <= 0; }
        }

        public bool IsDone
        {
            get { return Status == EmployeeTaskStatus.Done; }
        }



        public DateTime? ActualEndDate { get; set; }

        public string ActualEndDateText
        {
            get { return ActualEndDate != null && Status == EmployeeTaskStatus.Done ? ActualEndDate.Value.ToShortDateString() : string.Empty; }
        }

        public string DaysRemaining
        {
            get
            {
                return Status != EmployeeTaskStatus.Done
                    ? Math.Floor(DueDate.Subtract(DateTime.Now).TotalDays).ToString()
                    : string.Empty;
            }
        }


        public double Progress { get; set; }

        public string AssigneeName
        {
            get
            {
                return Assignee != null ? Assignee.FullName : string.Empty;
            }
        }

        public string AreaName
        {
            get { return Area == null ? string.Empty : Area.Name; }
        }
    }
}
