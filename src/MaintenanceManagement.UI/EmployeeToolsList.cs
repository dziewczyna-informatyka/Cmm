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
                    context.EmployeeTools
                        .Include(e => e.Owner)
                        .Include(e => e.ToolType)
                        .OrderBy(e => e.ToolType.Name)
                        .Where(e => ToolOwner.Id == e.Owner.Id)
                        .ToList();
            }
        }

        public Employee ToolOwner
        {
            get { return (Employee)toolOwner.Tag; }
            set { toolOwner.Tag = value; toolOwner.Text = value.ToString(); }
        }

        //-----------------------------------------------------------------------------

        private void newTool_Click(object sender, EventArgs eventArgs)
        {
            var form = new ToolEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var tool = form.EmployeeTool;

                    tool.Owner = context.Employees.Single(e => e.Id == tool.Owner.Id);
                    tool.ToolType = context.ToolTypes.Single(t => t.Id == tool.ToolType.Id);

                    context.EmployeeTools.Add(tool);
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
