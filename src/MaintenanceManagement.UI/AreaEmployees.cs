using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceManagement.UI
{
    public partial class AreaEmployees : Form
    {
        public AreaEmployees()
        {
            InitializeComponent();
        }

        private void AreaEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceManagementDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.maintenanceManagementDataSet.Employees);

        }
    }
}
