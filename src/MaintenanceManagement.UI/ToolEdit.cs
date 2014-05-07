using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;
using MaintenanceManagement.UI.Core;

namespace MaintenanceManagement.UI
{
    public partial class ToolEdit : Form
    {
        public ToolEdit()
        {
            InitializeComponent();

            using (var context = new MainContext())
            {
                if (UserContext.IsAdmin)
                {
                    toolOwner.DataSource = context.Employees.ToList();
                }
                else
                {
                    toolOwner.DataSource = new[] { UserContext.User };
                }

                toolTypeComboBox.DataSource = context.ToolTypes.ToList();
                toolEndReason.LoadEnumAsDataSource(typeof(ToolEndReason));
            }

            toolEndDate.Value = DateTime.Now;
        }

        protected override void OnLoad(EventArgs e)
        {
            toolOwner.Enabled = UserContext.IsAdmin;

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
                    EndDate = cbToolReturned.Checked ? toolEndDate.Value as DateTime? : null,
                    Quantity = (int)toolQuantity.Value,
                    ToolEndReason =
                        cbToolReturned.Checked && toolEndReason.SelectedValue != null
                            ? (ToolEndReason)toolEndReason.SelectedValue as ToolEndReason?
                            : null,
                    Comment = toolComment.Text,
                };
            }

            set
            {
                toolOwner.SelectedItem = value.Owner;
                toolTypeComboBox.SelectedItem = value.ToolType;
                toolStartDate.Value = value.StartDate;
                toolQuantity.Value = value.Quantity;
                toolEndReason.SelectedItem = value.ToolEndReason;
                toolComment.Text = value.Comment;

                if (value.EndDate != null)
                {
                    toolEndDate.Value = value.EndDate.GetValueOrDefault();
                }

                toolEndDate.Enabled = toolEndReason.Enabled = cbToolReturned.Checked = value.IsEnded;
            }
        }

        private void cbToolReturned_CheckedChanged(object sender, EventArgs e)
        {
            toolEndDate.Enabled = toolEndReason.Enabled = cbToolReturned.Checked;
        }
    }
}
