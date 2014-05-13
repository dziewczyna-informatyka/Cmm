using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;
using MaintenanceManagement.UI.Core;


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
            bibliotekiToolStripMenuItem.Visible = UserContext.IsAdmin;

            base.OnLoad(e);
        }

        /* ----------------------------------------------------------------------------- */

        private void narzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ToolsList();
            form.ShowDialog();
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeesList();
            form.ShowDialog();
        }

        private void obszaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AreasList();
            form.ShowDialog();
        }

        /* ----------------------------------------------------------------------------- */

        private void noweToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            var form = new TaskEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var task = form.EmployeeTask;

                    task.Area = context.Areas.SingleOrDefault(a => a.Id == task.Area.Id);
                    task.Assignee = context.Employees.SingleOrDefault(e => e.Id == task.Assignee.Id);

                    context.EmployeeTasks.Add(task);
                    context.SaveChanges();
                }

            }
        }

        private void aktualneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.InProgress };
            form.ShowDialog();
        }

        private void zaplanowaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Planned };
            form.ShowDialog();
        }

        private void zrealizowaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Done };
            form.ShowDialog();
        }

        private void zestawienieZbiorczeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksSummaryList();
            using (var context = new MainContext())
            {
                form.TasksAmount = context.EmployeeTasks.Count();
                form.ActualTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.InProgress);
                form.PlannedTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Planned);
                form.DoneTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Done);
            }
            form.ShowDialog();
        }

        //-----------------------------------------------------------------------------

        private void employeeExample_Click(object sender, EventArgs e)
        {
            Employee emp = UserContext.User;

            var form = new EmployeeTaskSummary { AssignedEmployee = emp };

            form.UpdateData();

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        //-----------------------------------------------------------------------------

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------------------------

        private void controllingButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

        private static void ShowAreaSummary(object sender)
        {
            Area area;

            using (var context = new MainContext())
            {
                area = context.Areas.SingleOrDefault(a => a.Name == ((Button)sender).Text);
            }

            if (area == null)
            {
                MessageBox.Show("Brak takiej brygady");
            }
            else
            {
                var form = new AreaSummary { AssignedArea = area };

                form.ShowDialog();
            }

        }

        private void wtryskarkiButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

        private void pakujaceButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

        private void ekstruderButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

        private void automatyButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

        private void facilityButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

      /*  private void brygadaAButton_Click(object sender, EventArgs e)
        {
            var form = new AreaSummary { AssignedArea = (Area)brygadaAButton.Tag };

            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void brygadaBButton_Click(object sender, EventArgs e)
        {
            var form = new AreaSummary { AssignedArea = (Area)brygadaBButton.Tag };

            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void brygadaCButton_Click(object sender, EventArgs e)
        {
            var form = new AreaSummary { AssignedArea = (Area)brygadaCButton.Tag };

            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void brygadaDButton_Click(object sender, EventArgs e)
        {
            var form = new AreaSummary { AssignedArea = (Area)brygadaDButton.Tag };

            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void warsztatButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }

        private void infrastrukturaButton_Click(object sender, EventArgs e)
        {
            ShowAreaSummary(sender);
        }*/

    }
}
