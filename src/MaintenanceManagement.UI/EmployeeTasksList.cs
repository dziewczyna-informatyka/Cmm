using System;
using System.Windows.Forms;

namespace MaintenanceManagement.UI
{
    public partial class EmployeeTasksList : Form
    {
        public EmployeeTasksList()
        {
            InitializeComponent();
        }

        private void EmployeeTaskList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTasks' table. You can move, or remove it, as needed.
            this.employeeTasksTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTasks);

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
