using System;

namespace MaintenanceManagement.DataAccess.Entities
{
    public class EmployeeTask : BaseEntity
    {
        public Employee Assignee { get; set; }

        public Area Area { get; set; }

        public string Subject { get; set; }

        public string Actions { get; set; }

        public EmployeeTaskStatus Status { get; set; }

        public DateTime DueDate { get; set; }

        public double Progress { get; set; }

        public string AssigneeName
        {
            get
            {
                return Assignee != null ? Assignee.FullName : string.Empty;
            }
        }
    }
}
