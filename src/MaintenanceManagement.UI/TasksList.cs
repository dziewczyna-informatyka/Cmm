using System;
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

        public EmployeeTaskStatus EmployeeTaskStatus
        {
            get { return (EmployeeTaskStatus)tasksStatus.Tag; }
            set
            {
                tasksStatus.Tag = value;
                tasksStatus.Text = value.EnumToString();
            }
        }

        private void TasksList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTasks' table. You can move, or remove it, as needed.
            this.employeeTasksTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTasks);

        }


    }
}
