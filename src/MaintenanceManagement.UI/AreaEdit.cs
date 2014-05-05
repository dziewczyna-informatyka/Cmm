using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess.Entities;
using MaintenanceManagement.UI.Core;

namespace MaintenanceManagement.UI
{
    public partial class AreaEdit : BaseEditWindow
    {
        public AreaEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            editedArea.DataBindings.Add("Text", DataContext, "Name");
            base.OnLoad(e);
        }
    }
}
