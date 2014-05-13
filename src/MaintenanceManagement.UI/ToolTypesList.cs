using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class ToolsList : Form
    {
        public ToolsList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateToolTypes();
            base.OnLoad(e);
        }

        //
        //uaktualnienie listy narzędzi
        //
        private void UpdateToolTypes()
        {
            toolTypeList.Items.Clear();

            using (var context = new MainContext())
            {
                foreach (var toolType in context.ToolTypes)
                {
                    toolTypeList.Items.Add(toolType.Name);
                }
            }
        }

        //
        //dodanie nowego typu narzędzi
        //
        private void addNewTool_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {
                context.ToolTypes.Add(new ToolType { Name = toolTypeName.Text });
                context.SaveChanges();
            }

            UpdateToolTypes();
        }

        private void deleteTool_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {
                var selectedToolType = (string)toolTypeList.SelectedItem;

                if (selectedToolType != null)
                {
                    context.ToolTypes.Remove(context.ToolTypes.Single(t => t.Name == selectedToolType));
                    context.SaveChanges();
                }
            }

            UpdateToolTypes();
        }

        private void toolTypesList_DoubleClick(object sender, EventArgs e)
        {
            var selectedToolType = (string)toolTypeList.SelectedItem;
            var form = new ToolTypeEdit { EditedText = selectedToolType };

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

        private void editTool_Click(object sender, EventArgs e)
        {
            var selectedToolType = (string)toolTypeList.SelectedItem;
            var form = new ToolTypeEdit { EditedText = selectedToolType };

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
