using System;
using System.Windows.Forms;

namespace MaintenanceManagement.UI
{
    public partial class EmployeeToolsList : Form
    {
        public EmployeeToolsList()
        {
            InitializeComponent();
        }

        // private void EmployeeToolsList_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTools' table. You can move, or remove it, as needed.
        //  this.employeeToolsTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTools);
        //}

        private void newTool_Click(object sender, EventArgs e)
        {
            var form = new ToolEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void editTool_Click(object sender, EventArgs e)
        {
            var form = new ToolEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }



    }
}
