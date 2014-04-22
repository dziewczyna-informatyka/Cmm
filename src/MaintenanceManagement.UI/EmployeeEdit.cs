using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class EmployeeEdit : Form
    {
        public EmployeeEdit()
        {
            InitializeComponent();

            LoadEmploymentTypes();
        }

        public Employee Employee
        {
            get
            {
                return new Employee()
                {
                    Name = employeeName.Text,
                    Surname = employeeSurname.Text,
                    PersonalNumber = int.Parse(employeePersonalNr.Text),
                    Address = employeeAdress.Text,
                    EmploymentStart = employeeEmploymentStart.Value,
                    EmploymentType = (EmploymentType)employeeEmploymentType.SelectedItem,
                    MobilePhone = employeeMobilePhone.Text,
                    HomePhone = employeePhone.Text,
                };
            }

            set
            {
                employeeName.Text = value.Name;
                employeeSurname.Text = value.Surname;
                employeePersonalNr.Text = value.PersonalNumber.ToString();
                employeeAdress.Text = value.Address;
                employeeEmploymentStart.Value = value.EmploymentStart.GetValueOrDefault();
                employeeEmploymentType.SelectedItem = value.EmploymentType;
                employeeMobilePhone.Text = value.MobilePhone;
                employeePhone.Text = value.HomePhone;
            }
        }

        private void LoadEmploymentTypes()
        {
            employeeEmploymentType.Items.Clear();

            employeeEmploymentType.DataSource = Enum.GetValues(typeof(EmploymentType));
        }
    }
}
