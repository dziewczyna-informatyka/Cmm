using System;
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
