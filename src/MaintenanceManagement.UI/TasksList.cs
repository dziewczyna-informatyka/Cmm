using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;

namespace MaintenanceManagement.UI
{
    public partial class TasksList : Form
    {
        public TasksList()
        {
            InitializeComponent();
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
