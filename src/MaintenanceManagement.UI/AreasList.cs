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
            using (var context = new MainContext())
            {
                areaList.DisplayMember = "Name";
                areaList.DataSource = context.Areas.ToList();
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
                var selectedArea = (Area)areaList.SelectedItem;

                if (selectedArea != null)
                {
                    context.Areas.Remove(context.Areas.Single(t => t.Id == selectedArea.Id));
                    context.SaveChanges();
                }
            }

            UpdateAreas();
        }

        private void editArea_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void areaList_DoubleClick(object sender, MouseEventArgs e)
        {
            EditSelected();
        }

        private void EditSelected()
        {
            var selectedArea = (Area)areaList.SelectedItem;
            var form = new AreaEdit { DataContext = selectedArea };

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var area = context.Areas.Single(t => t.Id == selectedArea.Id);

                    area.Name = ((Area)form.DataContext).Name;

                    context.SaveChanges();
                }

                UpdateAreas();
            }
        }
    }
}
