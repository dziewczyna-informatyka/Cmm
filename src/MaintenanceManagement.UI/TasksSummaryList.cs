using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class TasksSummaryList : Form
    {
        public TasksSummaryList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateTasks();
            base.OnLoad(e);
        }

        private void UpdateTasks()
        {
            tasksListDataGrid.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                tasksListDataGrid.DataSource = context.EmployeeTasks.Include(e=>e.Assignee).OrderBy(e => e.Progress).ToList();
            }
        }

        //-----------------------------------------------------------------------------

        public int PlannedTasksAmount
        {
            get { int v; return int.TryParse(plannedTasksAmount.Text, out v) ? v : 0; }
            set { plannedTasksAmount.Text = value.ToString(); }
        }

        public int ActualTasksAmount
        {
            get { int v; return int.TryParse(actualTasksAmount.Text, out v) ? v : 0; }
            set { actualTasksAmount.Text = value.ToString(); }
        }

        public int DoneTasksAmount
        {
            get { int v; return int.TryParse(doneTasksAmount.Text, out v) ? v : 0; }
            set { doneTasksAmount.Text = value.ToString(); }
        }

        public int TasksAmount
        {
            get { int v; return int.TryParse(totalTasksAmount.Text, out v) ? v : 0; }
            set { totalTasksAmount.Text = value.ToString(); }
        }

        //-----------------------------------------------------------------------------

        private void plannedTasks_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Planned };
            form.ShowDialog();
        }

        private void actualTasks_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.InProgress };
            form.ShowDialog();
        }

        private void doneTasks_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Done };
            form.ShowDialog();
        }

    }
}
