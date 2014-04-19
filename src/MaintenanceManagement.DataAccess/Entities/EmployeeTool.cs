﻿using System;

namespace MaintenanceManagement.DataAccess.Entities
{
    public class EmployeeTool
    {
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int Quantity { get; set; }

        public string Comment { get; set; }

        public ToolEndReason? ToolEndReason { get; set; }

        public Employee Employee { get; set; }

        public ToolType ToolType { get; set; }
    }
}
