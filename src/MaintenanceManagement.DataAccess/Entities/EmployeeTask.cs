using System;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.DataAccess.Entities
{
    public class EmployeeTask : BaseEntity
    {
        public Employee Assignee { get; set; }

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
