using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

            LoadAreas();
        }


        public Employee Employee
        {
            get
            {
                int number = 0;

                return new Employee()
                {
                    Name = employeeName.Text,
                    Surname = employeeSurname.Text,
                    PersonalNumber = int.TryParse(employeePersonalNr.Text, out number) ? number : 0,
                    Address = employeeAdress.Text,
                    EmploymentStart = employeeEmploymentStart.Value.Date,
                    EmploymentType = (EmploymentType)employeeEmploymentType.SelectedItem,
                    MobilePhone = employeeMobilePhone.Text,
                    HomePhone = employeePhone.Text,
                    Area = (Area)employeeArea.SelectedItem,
                    Team = employeeTeam.SelectedText,
                };
            }

            set
            {
                employeeName.Text = value.Name;
                employeeSurname.Text = value.Surname;
                employeePersonalNr.Text = value.PersonalNumber.ToString();
                employeeAdress.Text = value.Address;

                if (value.EmploymentStart != null)
                {
                    employeeEmploymentStart.Value = value.EmploymentStart.GetValueOrDefault();
                }

                employeeEmploymentType.SelectedItem = value.EmploymentType;
                employeeMobilePhone.Text = value.MobilePhone;
                employeePhone.Text = value.HomePhone;
                employeeArea.SelectedItem = value.Area;
                employeeTeam.SelectedText = value.Team;
            }
        }

        private void LoadEmploymentTypes()
        {
            employeeEmploymentType.Items.Clear();

            employeeEmploymentType.DataSource = Enum.GetValues(typeof(EmploymentType));
        }

        private void LoadAreas()
        {
            employeeArea.Items.Clear();

            using (var context = new MainContext())
            {
                employeeArea.DataSource = context.Areas.ToList();
            }
        
        }



    }
}
