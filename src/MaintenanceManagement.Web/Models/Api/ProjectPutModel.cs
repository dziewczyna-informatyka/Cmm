namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class ProjectPutModel : IIdentifiable
    {
        public int Id { get; set; }

        public string ProjectNumber { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string DueDate { get; set; }

        public IdNamePair Owner { get; set; }

        public IdNamePair Area { get; set; }
    }
}