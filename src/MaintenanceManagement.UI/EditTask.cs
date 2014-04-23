using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class EditTask : Form
    {
        public EditTask()
        {
            InitializeComponent();
        }

        private void NewEmployeeTask_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'maintenanceManagementDataSet.Employees' table. You can move, or remove it, as needed.
this.employeesTableAdapter.Fill(this.maintenanceManagementDataSet.Employees);

        }

        public EmployeeTask EmployeeTask
        {
            get
            {
                return new EmployeeTask()
                {
                    //Assignee = (Employee) taskResponsibleEmployee.Text;


                };

            }

            set
            {
                
            }

        }

 }
}
