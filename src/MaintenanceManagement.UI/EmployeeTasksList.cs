using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;


namespace MaintenanceManagement.UI
{
    public partial class EmployeeTasksList : Form
    {
        public EmployeeTasksList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateEmployeeTasks();
            base.OnLoad(e);
        }

        private void UpdateEmployeeTasks()
        {
            employeeTasksGridView.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                employeeTasksGridView.DataSource =
                    context.EmployeeTasks.Include(e => e.Assignee)
                        .OrderBy(e => e.Progress)
                        .Where(e => AssignedEmployee.Id == e.Id && e.Status == EmployeeTaskStatus)
                        .ToList();
            }
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

        public Employee AssignedEmployee
        {
            get { return (Employee)responsibleEmployee.Tag; }
            set
            {
                responsibleEmployee.Tag = value;
                responsibleEmployee.Text = value.FullName;
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
