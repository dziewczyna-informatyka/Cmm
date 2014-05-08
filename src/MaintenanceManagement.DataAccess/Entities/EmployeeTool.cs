using System;
using System.ComponentModel.DataAnnotations;
using MaintenanceManagement.Core;
using Microsoft.SqlServer.Server;

namespace MaintenanceManagement.DataAccess.Entities
{
    public class EmployeeTool : BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int Quantity { get; set; }

        public string Comment { get; set; }

        public ToolEndReason? ToolEndReason { get; set; }

        [Required]
        public virtual Employee Owner { get; set; }

        [Required]
        public virtual ToolType ToolType { get; set; }

        public string EndReasonName
        {
            get { return ToolEndReason == null ? string.Empty : ToolEndReason.Value.EnumToString(); }
        }

        public bool IsEnded
        {
            get { return EndDate != null; }
        }

        public string StartDateText
        {
            get { return StartDate.ToShortDateString(); }
        }

        public string EndDateText
        {
            get { return EndDate != null ? EndDate.Value.ToShortDateString() : string.Empty; }
        }


        public string ToolTypeName
        {
            get { return ToolType == null ? string.Empty : ToolType.Name; }
        }
    }
}
