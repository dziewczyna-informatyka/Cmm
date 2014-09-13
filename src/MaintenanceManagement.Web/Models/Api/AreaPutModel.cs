namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class AreaPutModel : IIdentifiable
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}