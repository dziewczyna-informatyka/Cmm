namespace MaintenanceManagement.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using System.Resources;

    public static class EnumExtensions
    {
        public static string EnumToString(this Enum e)
        {
            var info = e.GetType().GetMember(e.ToString()).First();
            var attr = info.GetCustomAttribute<DisplayAttribute>();

            return new ResourceManager(attr.ResourceType).GetString(attr.Name);
        }

        public static IdNamePair ToIdNamePair(this Enum e)
        {
            return e == null
                       ? new IdNamePair { Id = -1, Name = string.Empty }
                       : new IdNamePair { Id = Convert.ToInt32(e), Name = e.EnumToString() };
        }

        public static IEnumerable<IdNamePair> GetAllIdNamePairs<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<Enum>().Select(t => t.ToIdNamePair()).ToList();
        }
    }
}