namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MaintenanceManagement.Core;

    public class EmployeeTool : BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int Quantity { get; set; }

        public string Comment { get; set; }

        public ToolEndReason? ToolEndReason { get; set; }

        [Required]
        public Employee Owner { get; set; }

        [Required]
        public virtual ToolType ToolType { get; set; }

        public string EndReasonName
        {
            get { return this.ToolEndReason == null ? string.Empty : this.ToolEndReason.Value.EnumToString(); }
        }

        public bool IsEnded
        {
            get { return this.EndDate != null; }
        }

        public string StartDateText
        {
            get { return this.StartDate.ToShortDateString(); }
        }

        public string EndDateText
        {
            get { return this.EndDate != null ? this.EndDate.Value.ToShortDateString() : string.Empty; }
        }

        public string ToolTypeName
        {
            get { return ToolType == null ? string.Empty : ToolType.Name; }
        }
    }
}
