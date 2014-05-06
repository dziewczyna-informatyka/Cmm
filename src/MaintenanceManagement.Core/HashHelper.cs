using System;
using System.Security.Cryptography;
using System.Text;

namespace MaintenanceManagement.Core
{
    public static class HashHelper
    {
        public static string GetHash(string str)
        {
            var hash = MD5.Create();
            return Convert.ToBase64String(hash.ComputeHash(Encoding.Default.GetBytes(str)));
        }
    }
}