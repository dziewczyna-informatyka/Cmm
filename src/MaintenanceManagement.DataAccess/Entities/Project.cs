namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MaintenanceManagement.Core.Resources;

    public class Project : BaseEntity
    {
        [Index(IsUnique = true)]
        [StringLength(100)]
        [Display(ResourceType = typeof(Common), Name = "Project_Name")]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Project_DueDate")]
        public DateTime DueDate { get; set; }
    }
}