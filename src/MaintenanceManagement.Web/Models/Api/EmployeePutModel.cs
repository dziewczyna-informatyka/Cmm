namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class EmployeePutModel : IIdentifiable
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}