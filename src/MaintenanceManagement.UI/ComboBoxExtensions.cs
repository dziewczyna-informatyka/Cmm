using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.Core;

namespace MaintenanceManagement.UI
{
    public static class ComboBoxExtensions
    {
        public static void LoadEnumAsDataSource(this ComboBox comboBox, Type enumType)
        {
            comboBox.DataSource = Enum.GetValues(enumType)
                     .Cast<Enum>()
                     .Select(v => new { Value = v, Name = v.EnumToString() })
                     .ToList();
            comboBox.ValueMember = "Value";
            comboBox.DisplayMember = "Name";
        }
    }
}