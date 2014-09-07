namespace MaintenanceManagement.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ToolType : BaseEntity
    {
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
