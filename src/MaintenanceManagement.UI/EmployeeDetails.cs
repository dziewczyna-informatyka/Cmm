using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
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
