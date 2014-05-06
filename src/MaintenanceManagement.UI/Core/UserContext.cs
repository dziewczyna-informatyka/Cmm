using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI.Core
{
    public static class UserContext
    {
        public static Employee User { get; set; }
        public static bool IsAdmin { get { return User != null && User.IsAdmin; } }
    }
}