namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class EmployeeTaskPutModel : IIdentifiable
    {
        public int Id { get; set; }

        public IdNamePair Assignee { get; set; }

        public IdNamePair Area { get; set; }

        public string Subject { get; set; }

        public string Actions { get; set; }

        public IdNamePair Status { get; set; }

        public string DueDate { get; set; }

        public double Progress { get; set; }
    }
}