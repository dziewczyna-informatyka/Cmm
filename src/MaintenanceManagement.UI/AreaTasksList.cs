using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;

namespace MaintenanceManagement.UI
{
    public partial class AreaTasksList : Form
    {
        public AreaTasksList()
        {
            InitializeComponent();
            UpdateAreaTasks();
        }


        public EmployeeTaskStatus? TaskStatus
        {
            get { return (EmployeeTaskStatus?) tasksStatus.Tag; }
            set
            {
                tasksStatus.Tag = value;
                tasksStatus.Text = value != null ? value.EnumToString() : string.Empty;
            }
        }

        public Area AssignedArea
        {
            get { return (Area) assignedArea.Tag; }
            set
            {
                assignedArea.Tag = value;
                assignedArea.Text = value.Name;
            }
        }

        private void UpdateAreaTasks()
        {
            areaTasksGridView.AutoGenerateColumns = false;

            using (var context = new MainContext())
            {
                areaTasksGridView.DataSource =
                    context.EmployeeTasks
                        .Include(e => e.Assignee)
                        .Include(e => e.Area)
                        .OrderBy(e => e.Progress)
                        .Where(t => (t.Status == TaskStatus || TaskStatus == null))// && AssignedArea.Id == t.Area.Id)
                        .ToList();
            }
        }


    }
}
