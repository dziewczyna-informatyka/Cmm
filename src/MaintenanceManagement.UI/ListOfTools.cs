﻿using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class ListOfTools : Form
    {
        public ListOfTools()
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
            toolTypesList.Items.Clear();

            using (var context = new MainContext())
            {
                foreach (var toolType in context.ToolTypes)
                {
                    toolTypesList.Items.Add(toolType.Name);
                }
            }
        }

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
                var selectedToolType = (string)toolTypesList.SelectedItem;

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
            var selectedToolType = (string)toolTypesList.SelectedItem;
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

        private void editTool_Click(object sender, EventArgs e)
        {
            var selectedToolType = (string)toolTypesList.SelectedItem;
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
