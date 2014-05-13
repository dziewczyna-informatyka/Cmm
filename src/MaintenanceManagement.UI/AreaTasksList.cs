using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class AreaTasksList : Form
    {
        public AreaTasksList()
        {
            InitializeComponent();
            areaTasksGridView.DataBindingComplete += employeeTasksGridView_DataBindingComplete;
        }

        void employeeTasksGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                foreach (DataGridViewRow r in areaTasksGridView.Rows)
                {
                    var task = r.DataBoundItem as EmployeeTask;

                    if (task.IsDueDateWarning)
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (task.IsDueDateError)
                    {
                        r.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                    if (task.IsDone)
                    {
                        r.DefaultCellStyle.BackColor = Color.ForestGreen;
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateAreaTasks();
            base.OnLoad(e);
        }

        public EmployeeTaskStatus? TaskStatus
        {
            get { return (EmployeeTaskStatus?)tasksStatus.Tag; }
            set
            {
                tasksStatus.Tag = value;
                tasksStatus.Text = value != null ? value.EnumToString() : string.Empty;
            }
        }

        public Area AssignedArea
        {
            get { return (Area)assignedArea.Tag; }
            set
            {
                assignedArea.Tag = value;
                assignedArea.Text = value.Name;
            }
        }

        private void UpdateAreaTasks()
        {
            areaTasksGridView.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                areaTasksGridView.DataSource =
                    context.EmployeeTasks
                        .Include(e => e.Assignee)
                        .Include(e => e.Area)
                        .OrderBy(e => e.Progress)
                        .Where(t => (t.Status == TaskStatus || TaskStatus == null) && AssignedArea.Id == t.Area.Id)
                        .ToList();
            }
        }

        private void editTask_Click(object sender, EventArgs e)
        {
            if (areaTasksGridView.CurrentRow == null) { return; }

            var form = new TaskEdit();
            var selected = areaTasksGridView.CurrentRow.DataBoundItem as EmployeeTask;
            form.EmployeeTask = selected;
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var task = form.EmployeeTask;
                    task.Id = selected.Id;

                    var areaId = task.Area.Id;
                    var assigneeId = task.Assignee.Id;

                    task = context.UpdateDetached(task);

                    task.Area = context.Areas.SingleOrDefault(a => a.Id == areaId);
                    task.Assignee = context.Employees.SingleOrDefault(emp => emp.Id == assigneeId);

                    context.SaveChanges();
                }
            }

            UpdateAreaTasks();
        }


    }
}
