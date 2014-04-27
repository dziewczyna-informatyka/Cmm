using System.Windows.Forms;

namespace MaintenanceManagement.UI
{
    public partial class ToolTypeEdit : Form
    {
        public ToolTypeEdit()
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
