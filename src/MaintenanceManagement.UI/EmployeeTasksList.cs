using System;
using System.Linq;
using System.Windows.Forms;
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


        private void EmployeeTasksList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTasks' table. You can move, or remove it, as needed.
            this.employeeTasksTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTasks);

        }

        private void UpdateEmployeeTasks()
        {
            using (var context = new MainContext())
            {
               employeeTasksGridView.DataSource = context.EmployeeTasks.OrderBy(e => e.Assignee).ToList();
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
