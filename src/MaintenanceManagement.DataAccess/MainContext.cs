namespace MaintenanceManagement.DataAccess
{
    using System.Data.Entity;
    using System.Linq;

    using MaintenanceManagement.DataAccess.Entities;

    /// <summary>
    /// Polaczenie z baza danych
    /// </summary>
    public class MainContext : DbContext
    {
        public MainContext()
            : base("Name=MainConnectionString")
        {
        }

        public IDbSet<Area> Areas { get; set; }

        public IDbSet<Employee> Employees { get; set; }

        public IDbSet<EmployeeTask> EmployeeTasks { get; set; }

        public IDbSet<EmployeeTool> EmployeeTools { get; set; }

        public IDbSet<ToolType> ToolTypes { get; set; }

        public T UpdateDetached<T>(T entity) where T : BaseEntity
        {
            var databaseEntity = Set<T>().Single(e => e.Id == entity.Id);
            var entry = ChangeTracker.Entries<T>().Single(e => e.Entity.Id == entity.Id);
            entry.CurrentValues.SetValues(entity);

            return databaseEntity;
        }
    }
}
