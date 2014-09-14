namespace MaintenanceManagement.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MaintenanceManagement.Core.Resources;

    public class ToolType : BaseEntity
    {
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Display(ResourceType = typeof(Common), Name = "ToolType_Name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
