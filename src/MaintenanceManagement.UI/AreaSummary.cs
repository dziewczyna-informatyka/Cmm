using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;
using MaintenanceManagement.UI.Core;

namespace MaintenanceManagement.UI
{
    public partial class AreaSummary : Form
    {
        public AreaSummary()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            panel5.Visible = UserContext.IsAdmin || UserContext.User.Area.Id == AssignedArea.Id;
            UpdateData();
            base.OnLoad(e);
        }

        public void UpdateData()
        {
            using (var context = new MainContext())
            {
                employeesDataGridView.DataSource = context.Employees.Include(e => e.Area).OrderBy(e => e.Surname).Where(e => e.Area.Id == AssignedArea.Id).ToList();
                TasksAmount = context.EmployeeTasks.Count(a => a.Area.Id == AssignedArea.Id);
                ActualTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.InProgress && a.Area.Id == AssignedArea.Id);
                PlannedTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Planned && a.Area.Id == AssignedArea.Id);
                DoneTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Done && a.Area.Id == AssignedArea.Id);
            }
        }

        public Area AssignedArea
        {
            get { return (Area)employeesArea.Tag; }
            set
            {
                employeesArea.Tag = value;
                employeesArea.Text = value.ToString();
            }
        }

        private void employeeTasksDetails_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.CurrentRow == null)
            {
                return;
            }

            var form = new EmployeeTaskSummary();
            var selected = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
            form.AssignedEmployee = selected;

            if (form.ShowDialog() == DialogResult.OK)
            {

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
            var form = new AreaTasksList { TaskStatus = EmployeeTaskStatus.Planned, AssignedArea = AssignedArea };

            form.ShowDialog();

            UpdateData();
        }

        private void actualTasks_Click(object sender, EventArgs e)
        {
            var form = new AreaTasksList { TaskStatus = EmployeeTaskStatus.InProgress, AssignedArea = AssignedArea };

            form.ShowDialog();

            UpdateData();
        }

        private void doneTasks_Click(object sender, EventArgs e)
        {
            var form = new AreaTasksList { TaskStatus = EmployeeTaskStatus.Done, AssignedArea = AssignedArea };

            form.ShowDialog();

            UpdateData();
        }

        private void allTasks_Click(object sender, EventArgs e)
        {
            var form = new AreaTaskSummaryList() { AssignedArea = AssignedArea };

            form.ShowDialog();

            UpdateData();
        }

        //-----------------------------------------------------------------------------

        private void newTasksCreator_Click(object sender, EventArgs e)
        {

             var form = new TaskEdit();
             var selected = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
             form.AssignedEmployee = selected;
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var task = form.EmployeeTask;

                    task.Area = context.Areas.SingleOrDefault(a => a.Id == task.Area.Id);
                    task.Assignee = context.Employees.SingleOrDefault(emp => emp.Id == task.Assignee.Id);

                    context.EmployeeTasks.Add(task);
                    context.SaveChanges();
                }
            }

            UpdateData();
        }
    }
}
