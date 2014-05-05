using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class ToolEdit : Form
    {
        public ToolEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            using (var context = new MainContext())
            {
                toolOwner.DataSource = context.Employees.ToList();
                toolTypeComboBox.DataSource = context.ToolTypes.ToList();
                toolEndReason.LoadEnumAsDataSource(typeof(ToolEndReason));
            }

            base.OnLoad(e);
        }

        public EmployeeTool EmployeeTool
        {
            get
            {
                return new EmployeeTool
                {
                    Owner = (Employee)toolOwner.SelectedItem,
                    ToolType = (ToolType)toolTypeComboBox.SelectedItem,
                    StartDate = toolStartDate.Value.Date,
                    EndDate = toolEndDate.Value.Date,
                    Quantity = Convert.ToInt16(toolQuantity.Text),
                    ToolEndReason = (ToolEndReason)toolEndReason.SelectedItem,
                    Comment = toolComment.Text,
                };
            }

            set
            {
                toolOwner.SelectedItem = value.Owner;
                toolTypeComboBox.SelectedItem = value.ToolType;
                toolStartDate.Value = value.StartDate;
                toolEndDate.Value = value.EndDate.GetValueOrDefault();
                toolQuantity.Text = value.Quantity.ToString();
                toolEndReason.SelectedItem = value.ToolEndReason;
                toolComment.Text = value.Comment;
            }
        }
    }
}
