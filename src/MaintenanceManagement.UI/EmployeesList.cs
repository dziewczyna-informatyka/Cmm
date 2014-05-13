using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class EmployeesList : Form
    {
        public EmployeesList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateEmployees();
            base.OnLoad(e);
        }

        //
        //aktualizacja listy pracowników
        //
        private void UpdateEmployees()
        {
            using (var context = new MainContext())
            {
                employeesDataGridView.DataSource =
                    context.Employees.Include(e => e.Area).OrderBy(e => e.Surname).ToList();
            }
        }

        //
        //dodawanie nowego pracownika
        //
        private void newEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEdit();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var employee = form.Employee;
                    employee.Area = context.Areas.SingleOrDefault(a => a.Id == form.Employee.Area.Id);
                    employee.PasswordHash = HashHelper.GetHash(employee.PasswordHash);
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }
            }

            UpdateEmployees();

        }

        //
        //podgląd szczegółów
        //
        private void previewOfEmployee_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.CurrentRow == null)
            {
                return;
            }

            var form = new EmployeeDetails
            {
                Employee = employeesDataGridView.CurrentRow.DataBoundItem as Employee,
            };

            form.Show();
        }

        //
        //edycja danych pracownika
        //
        private void editEmployee_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.CurrentRow == null)
            {
                return;
            }

            var employee = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
            var form = new EmployeeEdit
            {
                Employee = employee,
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var databaseEmployee = context.Employees.Single(emp => emp.Id == employee.Id);
                    databaseEmployee.Area = context.Areas.SingleOrDefault(a => a.Id == form.Employee.Area.Id);
                    databaseEmployee.Name = form.Employee.Name;
                    databaseEmployee.Surname = form.Employee.Surname;
                    databaseEmployee.Address = form.Employee.Address;
                    databaseEmployee.HomePhone = form.Employee.HomePhone;
                    databaseEmployee.MobilePhone = form.Employee.MobilePhone;
                    databaseEmployee.EmploymentStart = form.Employee.EmploymentStart;
                    databaseEmployee.EmploymentType = form.Employee.EmploymentType;
                    databaseEmployee.JobTitle = form.Employee.JobTitle;
                    databaseEmployee.PersonalNumber = form.Employee.PersonalNumber;
                    databaseEmployee.Team = form.Employee.Team;
                    databaseEmployee.Login = form.Employee.Login;

                    if (!string.IsNullOrWhiteSpace(form.Employee.PasswordHash))
                    {
                        databaseEmployee.PasswordHash = HashHelper.GetHash(form.Employee.PasswordHash);
                    }

                    context.SaveChanges();
                }

                UpdateEmployees();
            }
        }

        //
        //usuwanie pracownika z listy
        //
        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.CurrentRow == null)
            {
                return;
            }
            using (var context = new MainContext())
            {
                var employee = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
                var employeeToDelete = context.Employees.Single(emp => emp.Id == employee.Id);
                context.Employees.Remove(employeeToDelete);
                context.SaveChanges();
            }

            UpdateEmployees();
        }

    }
}




