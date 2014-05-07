using System;
using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess.Entities
{
    public class EmployeeTask : BaseEntity
    {
        [Required]
        public virtual Employee Assignee { get; set; }

        [Required]
        public virtual Area Area { get; set; }

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

        //public DateTime? ActualEndDate { get; set; }

        //public string ActualEndDateText
        //{
        //    get { return ActualEndDate != null ? ActualEndDate.Value.ToShortDateString() : string.Empty; }
        //}

        public int DaysRemaining
        {
            get { return (int)Math.Floor(DateTime.Now.Subtract(DueDate).TotalDays); }
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
