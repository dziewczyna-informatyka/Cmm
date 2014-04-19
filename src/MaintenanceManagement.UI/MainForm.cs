using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateToolTypes();
            base.OnLoad(e);
        }

        private void UpdateToolTypes()
        {
            toolTypes.Items.Clear();

            using (var context = new MainContext())
            {
                foreach (var toolType in context.ToolTypes)
                {
                    toolTypes.Items.Add(toolType.Name);
                }
            }
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {
                context.ToolTypes.Add(new ToolType { Name = toolTypeName.Text });
                context.SaveChanges();
            }

            UpdateToolTypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {
                var selectedToolType = (string)toolTypes.SelectedItem;

                if (selectedToolType != null)
                {
                    context.ToolTypes.Remove(context.ToolTypes.Single(t => t.Name == selectedToolType));
                    context.SaveChanges();
                }
            }

            UpdateToolTypes();
        }

        private void toolTypes_DoubleClick(object sender, EventArgs e)
        {
            var selectedToolType = (string)toolTypes.SelectedItem;
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
            }
        }
    }
}
