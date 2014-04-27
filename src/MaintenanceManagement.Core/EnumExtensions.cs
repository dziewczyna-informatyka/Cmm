using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace MaintenanceManagement.Core
{
    public static class EnumExtensions
    {
        public static string EnumToString(this Enum e)
        {
            var info = e.GetType().GetMember(e.ToString()).First();
            var attr = info.GetCustomAttribute<DisplayAttribute>();

            return new ResourceManager(attr.ResourceType).GetString(attr.Name);            
        }
    }
}