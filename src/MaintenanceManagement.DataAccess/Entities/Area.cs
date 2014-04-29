namespace MaintenanceManagement.DataAccess.Entities
{
    public class Area : BaseEntity
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
