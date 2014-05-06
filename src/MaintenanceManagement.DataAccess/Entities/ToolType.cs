using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaintenanceManagement.DataAccess.Entities
{
    public class ToolType : BaseEntity
    {
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
