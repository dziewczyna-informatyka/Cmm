using System;
using System.Data.Entity;
using System.Linq;
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

        protected override void OnLoad(EventArgs e)
        {
            UpdateTools();
            base.OnLoad(e);
        }

        private void UpdateTools()
        {
            toolsListDataGrid.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                toolsListDataGrid.DataSource =
                    context.EmployeeTools.
                        Include(e => e.Owner).
                        OrderBy(e => e.ToolType).
                        Where(e => ToolOwner == e.Owner).
                        ToList();
            }
        }

        public Employee ToolOwner
        {
            get { return (Employee)toolOwner.Tag; }
            set { toolOwner.Tag = value; toolOwner.Text = value.ToString(); }
        }

        //-----------------------------------------------------------------------------

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

        


    }
}
