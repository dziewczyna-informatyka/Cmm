using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;

namespace MaintenanceManagement.UI
{
    public partial class TasksSummaryList : Form
    {
        public TasksSummaryList()
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
        private void TasksSummaryList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTasks' table. You can move, or remove it, as needed.
            this.employeeTasksTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTasks);

        }

        private void plannedTasks_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Planned };
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void actualTasks_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.InProgress };
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void doneTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
