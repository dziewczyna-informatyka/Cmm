using System;
using System.Windows.Forms;

namespace MaintenanceManagement.UI
{
    public partial class EmployeeTaskSummary : Form
    {
        public EmployeeTaskSummary()
        {
            InitializeComponent();
        }

        private void plannedTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList();
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void actualTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList();
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void doneTasks_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTasksList();
            
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
