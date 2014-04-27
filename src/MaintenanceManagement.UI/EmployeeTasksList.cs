using System;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;


namespace MaintenanceManagement.UI
{
    public partial class EmployeeTasksList : Form
    {
        public EmployeeTasksList()
        {
            InitializeComponent();
        }


        private void EmployeeTasksList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTasks' table. You can move, or remove it, as needed.
            this.employeeTasksTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTasks);

        }

        public EmployeeTaskStatus EmployeeTaskStatus
        {
            get { return (EmployeeTaskStatus)tasksStatus.Tag; }
            set
            {
                tasksStatus.Tag = value;
                tasksStatus.Text = value.ToString();
            }
        }

        public string AssignedEmployee
        {
            get { return (string) responsibleEmployee.Tag; }
            set
            {
                responsibleEmployee.Tag = value;
               // responsibleEmployee.Text = value.ToString();
            }
        }


        private void editTask_Click(object sender, EventArgs e)
        {
            var form = new TaskEdit();

            if (form.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}
