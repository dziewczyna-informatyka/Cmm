namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class AreaGetModel : IIdNamePair
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}