using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class TasksList : Form
    {
        public TasksList()
        {
            InitializeComponent();

            taskListDataGrid.DataBindingComplete += employeeTasksGridView_DataBindingComplete;
        }

        void employeeTasksGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                foreach (DataGridViewRow r in taskListDataGrid.Rows)
                {
                    var task = r.DataBoundItem as EmployeeTask;

                    if (task == null) { return; }

                    if (task.IsDueDateWarning)
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (task.IsDueDateError)
                    {
                        r.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }

                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateTasks();
            base.OnLoad(e);
        }

        public EmployeeTaskStatus EmployeeTaskStatus
        {
            get { return (EmployeeTaskStatus)tasksStatus.Tag; }
            set
            {
                tasksStatus.Tag = value;
                tasksStatus.Text = value.EnumToString();
            }
        }

        private void UpdateTasks()
        {
            taskListDataGrid.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                taskListDataGrid.DataSource =
                     context.EmployeeTasks
                        .Include(e => e.Assignee)
                        .Include(e => e.Area)
                        .OrderBy(e => e.Progress)
                        .Where(e => EmployeeTaskStatus == e.Status)
                        .ToList();


            }
        }
    }
}
