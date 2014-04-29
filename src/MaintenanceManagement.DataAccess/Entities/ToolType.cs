namespace MaintenanceManagement.DataAccess.Entities
{
    public class ToolType : BaseEntity
    {
        public string Name { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
