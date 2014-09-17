namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class EmployeeTaskPostModel
    {
        public IdNamePair Assignee { get; set; }

        public IdNamePair Area { get; set; }

        public string Subject { get; set; }

        public string Actions { get; set; }

        public string DueDate { get; set; }

        public double Progress { get; set; }

        public IdNamePair Board { get; set; }
    }
}