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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public string EditedText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
