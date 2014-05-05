using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;
using MaintenanceManagement.UI.Core;

namespace MaintenanceManagement.UI
{
    public partial class TaskEdit : Form
    {
        public TaskEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {           
            taskStatus.LoadEnumAsDataSource(typeof(EmployeeTaskStatus));

            using (var context = new MainContext())
            {
                taskAssignee.DataSource = context.Employees.ToList();
                taskArea.DataSource = context.Areas.ToList();
            }

            base.OnLoad(e);
        }

        public EmployeeTask EmployeeTask
        {
            get
            {
                return new EmployeeTask()
                {
                    Subject = taskSubject.Text,
                    Actions = taskActions.Text,
                    DueDate = taskDueDate.Value,
                    Assignee = (Employee)taskAssignee.SelectedItem,
                    Status = (EmployeeTaskStatus)taskStatus.SelectedValue,
                    Area = (Area)taskArea.SelectedItem,
                    Progress = int.Parse(taskProgress.Text),

                };
            }

            set
            {
                taskSubject.Text = value.Subject;
                taskActions.Text = value.Actions;
                taskDueDate.Value = value.DueDate;
                taskAssignee.SelectedItem = value.Assignee;
                taskStatus.SelectedItem = value.Status;
                taskArea.SelectedItem = value.Area;
                taskProgress.Text = value.Progress.ToString();

            }
        }

        private void saveTask_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {

            }
        }
    }
}





