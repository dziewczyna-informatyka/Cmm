using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var form = new EditTask();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
    }
}
