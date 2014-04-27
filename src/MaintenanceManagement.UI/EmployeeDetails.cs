using System;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        public Employee Employee
        {            
            set
            {
                employeeName.Text = value.Name;
                employeeSurname.Text = value.Surname;
                employeePersonalNr.Text = value.PersonalNumber.ToString();
                employeeAdress.Text = value.Address;
                employeeEmploymentStart.Text = value.EmploymentStart.GetValueOrDefault().ToString();
                employeeEmploymentType.Text = value.EmploymentType.ToString();
                employeeMobilePhone.Text = value.MobilePhone;
                employeePhone.Text = value.HomePhone;
            }
        }

        private void ack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
