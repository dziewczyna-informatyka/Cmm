namespace MaintenanceManagement.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class TaskBoard : BaseEntity
    {
        public virtual IList<EmployeeTask> Tasks { get; set; }

        public bool IsInProgress
        {
            get
            {
                return this.Tasks != null && this.Tasks.Any(t => t.Status != EmployeeTaskStatus.Planned);
            }
        }

        public bool IsFinished
        {
            get
            {
                return this.Tasks != null && this.Tasks.All(t => t.Status == EmployeeTaskStatus.Done);
            }
        }
    }
}