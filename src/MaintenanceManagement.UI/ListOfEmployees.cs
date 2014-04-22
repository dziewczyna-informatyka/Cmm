using System;
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
            employeesList.Items.Clear();

            using (var context = new MainContext())
            {
                foreach (var employee in context.Employees)
                {
                    employeesList.Items.Add(employee.Surname);
                }
            }
        }

        private void newEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEdit();
            form.ShowDialog();
            UpdateEmployees();
        }
        
        private void previewOfEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeDetails();
            var selectedEmployee = employeesList.SelectedItems;

            /*if (form.ShowDialog() == DialogResult.OK())
            {
                using (var context = new MainContext())
                {
                    var employee = context.Employees.Single(emp => emp.PersonalNumber == selectedEmployee.PersonalNumber);
                }
            }*/


            form.ShowDialog();
        }
        
      /*  private void editEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEdit();
            var selectedEmployee = listViewEmployees.SelectedItems;
            
            /* var selectedToolType = (string)toolTypesList.SelectedItem;
             var form = new EditForm { EditedText = selectedToolType };

             if (form.ShowDialog() == DialogResult.OK)
             {
                 using (var context = new MainContext())
                 {
                     var toolType = context.ToolTypes.Single(t => t.Name == selectedToolType);

                     toolType.Name = form.EditedText;

                     context.SaveChanges();
                 }

                 UpdateToolTypes();

            form.ShowDialog();
        }
    */

        private void editEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEdit();
            var selectedEmployee = employeesList.SelectedItems;
            form.ShowDialog();
        }

       
    }



}
