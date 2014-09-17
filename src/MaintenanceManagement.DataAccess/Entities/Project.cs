namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MaintenanceManagement.Core.Resources;

    public class Project : BaseEntity
    {
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Display(ResourceType = typeof(Common), Name = "Project_ProjectNumber")]
        public string ProjectNumber { get; set; }

        [Index(IsUnique = true)]
        [StringLength(100)]
        [Display(ResourceType = typeof(Common), Name = "Project_Name")]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Project_Description")]
        public string Description { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Project_DueDate")]
        public DateTime DueDate { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Project_Owner")]       
        public virtual Employee Owner { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Project_Area")]      
        public virtual Area Area { get; set; }

        public virtual TaskBoard BoardA { get; set; }

        public virtual TaskBoard BoardB { get; set; }

        public virtual TaskBoard BoardC { get; set; }
    }
}