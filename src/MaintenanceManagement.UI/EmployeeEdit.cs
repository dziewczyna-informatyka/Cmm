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
        }


        private void addNewEmployee_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {

             //   var emp = new Employee()
                {
                   // Name = employeeName.Text,
                    //  Surname = employeeSurname.Text,
                    //  PersonalNumber = (int)employeePersonalNr.ValidateText(),
                    //  Address = String.Concat(employeeAdress1.Text, employeeAdress2.Text),
                    //  EmploymentStart = employeeEmploymentStart.Value,
                    //  EmploymentType = (EmploymentType)employeeEmploymentType.SelectedItem,
                    //  MobilePhone = employeeMobilePhone.Text,
                    //  HomePhone = employeePhone.Text,
                };
                // w tym miejscu wywala błąd - baza danych zmieniła się od ostatniej migracji?
            //    context.Employees.Add(emp);
            //    context.SaveChanges();

            }

            Close();

        }

        private void employeeSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }




}
