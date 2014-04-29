using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class AreasList : Form
    {
        public AreasList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateAreas();
            base.OnLoad(e);
        }

        //
        //uaktualnienie listy obszarów
        //
        private void UpdateAreas()
        {
            areaList.Items.Clear();

            using (var context = new MainContext())
            {
                foreach (var area in context.Areas)
                {
                    areaList.Items.Add(area.Name);
                }
            }
        }

        //
        //dodanie nowego obszaru
        //
        private void addNewArea_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {
                context.Areas.Add(new Area { Name = areaName.Text });
                context.SaveChanges();
            }

            UpdateAreas();
        }

        private void deleteArea_Click(object sender, EventArgs e)
        {
            using (var context = new MainContext())
            {
                var selectedArea = (string)areaList.SelectedItem;

                if (selectedArea != null)
                {
                    context.Areas.Remove(context.Areas.Single(t => t.Name == selectedArea));
                    context.SaveChanges();
                }
            }

            UpdateAreas();
        }

        private void editArea_Click(object sender, EventArgs e)
        {
            var selectedArea = (string)areaList.SelectedItem;
            var form = new AreaEdit { EditedName = selectedArea };

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var area = context.Areas.Single(t => t.Name == selectedArea);

                    area.Name = form.EditedName;

                    context.SaveChanges();
                }

                UpdateAreas();
            }
        }

        private void areaList_DoubleClick(object sender, EventArgs e)
        {
            var selectedArea = (string)areaList.SelectedItem;
            var form = new AreaEdit { EditedName = selectedArea };

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var area = context.Areas.Single(t => t.Name == selectedArea);

                    area.Name = form.EditedName;

                    context.SaveChanges();
                }

                UpdateAreas();
            }
        }

    }
}
