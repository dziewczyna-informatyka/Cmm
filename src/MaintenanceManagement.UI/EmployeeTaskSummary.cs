using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;


namespace MaintenanceManagement.UI
{
    public partial class EmployeeTaskSummary : Form
    {
        public EmployeeTaskSummary()
        {
            InitializeComponent();
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

        public Employee AssignedEmployee
        {
            get { return (Employee)responsibleEmployee.Tag; }
            set
            {
                responsibleEmployee.Tag = value;
                responsibleEmployee.Text = value.ToString();
            }
        }

        //-----------------------------------------------------------------------------

        private void plannedTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList { EmployeeTaskStatus = EmployeeTaskStatus.Planned, AssignedEmployee = AssignedEmployee };

            if (form.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void actualTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList { EmployeeTaskStatus = EmployeeTaskStatus.InProgress, AssignedEmployee = AssignedEmployee };

            if (form.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void doneTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList { EmployeeTaskStatus = EmployeeTaskStatus.Done, AssignedEmployee = AssignedEmployee };

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void allTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList();

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        //-----------------------------------------------------------------------------

        private void newTasksCreator_Click(object sender, EventArgs e)
        {
            var form = new TaskEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    context.EmployeeTasks.Add(form.EmployeeTask);
                    context.SaveChanges();
                }
            }
        }

        //-----------------------------------------------------------------------------

        private void employeeTools_Click(object sender, EventArgs e)
        {
            var form = new EmployeeToolsList
            {
                ToolOwner = AssignedEmployee
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

    }
}
