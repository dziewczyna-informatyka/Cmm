﻿using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;


namespace MaintenanceManagement.UI
{
    public partial class EmployeeTasksList : Form
    {
        public EmployeeTasksList()
        {
            InitializeComponent();

            employeeTasksGridView.DataBindingComplete += employeeTasksGridView_DataBindingComplete;
        }

        void employeeTasksGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                foreach (DataGridViewRow r in employeeTasksGridView.Rows)
                {
                    var task = r.DataBoundItem as EmployeeTask;

                    if (task.IsDueDateWarning)
                    {
                        r.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else if (task.IsDueDateError)
                    {
                        r.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateEmployeeTasks();
            base.OnLoad(e);
        }

        private void UpdateEmployeeTasks()
        {
            employeeTasksGridView.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                employeeTasksGridView.DataSource =
                    context.EmployeeTasks
                        .Include(e => e.Assignee)
                        .Include(e => e.Area)
                        .OrderBy(e => e.Progress)
                        .Where(t => AssignedEmployee.Id == t.Assignee.Id && (t.Status == EmployeeTaskStatus || EmployeeTaskStatus == null))
                        .ToList();
            }
        }

        //-----------------------------------------------------------------------------

        public EmployeeTaskStatus? EmployeeTaskStatus
        {
            get { return (EmployeeTaskStatus?)tasksStatus.Tag; }
            set
            {
                tasksStatus.Tag = value;
                tasksStatus.Text = value != null ? value.EnumToString() : string.Empty;
            }
        }

        public Employee AssignedEmployee
        {
            get { return (Employee)responsibleEmployee.Tag; }
            set
            {
                responsibleEmployee.Tag = value;
                responsibleEmployee.Text = value.Area.Name;
            }
        }

        //-----------------------------------------------------------------------------

        private void editTask_Click(object sender, EventArgs eventArgs)
        {
            if (employeeTasksGridView.CurrentRow == null) { return; }

            var form = new TaskEdit();
            var selected = employeeTasksGridView.CurrentRow.DataBoundItem as EmployeeTask;
            form.EmployeeTask = selected;

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var task = form.EmployeeTask;
                    task.Id = selected.Id;

                    var areaId = task.Area.Id;
                    var assigneeId = task.Assignee.Id;

                    task = context.UpdateDetached(task);

                    task.Area = context.Areas.SingleOrDefault(a => a.Id == areaId);
                    task.Assignee = context.Employees.SingleOrDefault(e => e.Id == assigneeId);

                    context.SaveChanges();
                }
            }

            UpdateEmployeeTasks();
        }

    }
}
