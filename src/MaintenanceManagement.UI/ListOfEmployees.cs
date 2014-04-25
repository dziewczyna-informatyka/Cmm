using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class ListOfEmployees : Form
    {
        public ListOfEmployees()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateEmployees();
            base.OnLoad(e);
        }

        private void UpdateEmployees()
        {
            using (var context = new MainContext())
            {
                employeesDataGridView.DataSource = context.Employees.OrderBy(e => e.Surname).ToList();
                //
                //sortowanie nie działa :(
                //
                // employeesDataGridView.Sort(surnameDataGridViewTextBoxColumn, ListSortDirection.Ascending);
            }
        }

        private void ListOfEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.Employees' table. You can move, or remove it, as needed.
            // this.employeesTableAdapter.Fill(this.maintenanceManagementDataSet.Employees);
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
                    context.Employees.Add(form.Employee);
                    context.SaveChanges();
                }

                UpdateEmployees();
            }

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

            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    using (var context = new MainContext())
            //    {
            //        if (employeesDataGridView.CurrentRow != null)
            //        {
            //            int persNr = Convert.ToInt32(employeesDataGridView.CurrentRow.Cells[2].Value);

            //            MessageBox.Show(Convert.ToString(persNr));
            //        }
            //        // DataGridViewRow currentRow = employeesDataGridView.SelectedRows[0];
            //        // int persNr = int.Parse(currentRow.Cells[2].Value.ToString());
            //    }
            //}
        }
        //
        //edycja danych pracownika
        //
        private void editEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeDetails();

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
        //
        //usuwanie pracownika z listy
        //
        private void deleteEmployee_Click(object sender, EventArgs e)
        {

        }


    }
}




