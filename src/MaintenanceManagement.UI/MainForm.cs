using System;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void narzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ToolsList();
            form.ShowDialog();
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeesList();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void employeeExample_Click(object sender, EventArgs e)
        {
            var form = new EmployeeTaskSummary();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void noweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TaskEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void aktualneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.InProgress };

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void zaplanowaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Planned };
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void zrealizowaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Done };
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void zestawienieZbiorczeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}
