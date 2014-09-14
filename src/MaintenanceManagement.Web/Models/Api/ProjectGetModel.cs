namespace MaintenanceManagement.Web.Models.Api
{
    public class ProjectGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DueDate { get; set; }

        public string Progress { get; set; }
    }
}