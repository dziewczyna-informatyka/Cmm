using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

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
            taskStatus.DataSource = Enum.GetValues(typeof(EmployeeTaskStatus)); //wyświetla angielskie nazwy

            using (var context = new MainContext())
            {
                taskAssignee.DataSource = context.Employees.ToList();
                //taskAssignee.SelectedItem =
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
                    Status = (EmployeeTaskStatus)taskStatus.SelectedItem,

                };
            }

            set
            {
                taskSubject.Text = value.Subject;
                taskActions.Text = value.Actions;
                taskDueDate.Value = value.DueDate;
                taskAssignee.SelectedItem = value.Assignee;
                taskStatus.SelectedItem = value.Status;

            }
        }

        private void TaskEdit_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.EmployeeTasks' table. You can move, or remove it, as needed.
            this.employeeTasksTableAdapter.Fill(this.maintenanceManagementDataSet.EmployeeTasks);

        }

        private void saveTask_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {

            }
        }
    }
}





