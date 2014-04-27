using System;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;


namespace MaintenanceManagement.UI
{
    public partial class EmployeeTaskSummary : Form
    {
        public EmployeeTaskSummary()
        {
            InitializeComponent();
        }
        
        public Employee AssignedEmployee
        {
            get { return (Employee)responsibleEmployee.Tag; }
            set
            {
                responsibleEmployee.Tag = value;
                responsibleEmployee.Text = value.ToString();
            }
        }

        private void plannedTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList {EmployeeTaskStatus = EmployeeTaskStatus.Planned, AssignedEmployee = responsibleEmployee.Text};          
        }

        private void actualTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList {EmployeeTaskStatus = EmployeeTaskStatus.InProgress};
            
            if (form.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void doneTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList {EmployeeTaskStatus = EmployeeTaskStatus.Done};

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }


        private void newTasksCreator_Click(object sender, EventArgs e)
        {
            var form = new TaskEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void employeeTools_Click(object sender, EventArgs e)
        {
            var form = new EmployeeToolsList();
  
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
    }
}
