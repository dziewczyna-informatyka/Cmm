namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class ToolTypePutModel : IIdentifiable
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}