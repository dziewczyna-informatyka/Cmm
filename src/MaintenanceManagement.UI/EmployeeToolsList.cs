using System;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

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
                using (var context = new MainContext())
                {
                    context.EmployeeTools.Add(form.EmployeeTool);
                    context.SaveChanges();
                }
            }
        }

        private void editTool_Click(object sender, EventArgs e)
        {
            var form = new ToolEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public Employee ToolOwner
        {
            get { return (Employee)toolOwner.Tag; }
            set
            {
                toolOwner.Tag = value;
                toolOwner.Text = value.ToString();
            }
        }


    }
}
