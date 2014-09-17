namespace MaintenanceManagement.Web.Core
{
    using System;
    using System.Linq;
    using System.Web.Security;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess;

    public class CmmRoleProvider : RoleProvider
    {
        public override string ApplicationName { get; set; }

        public override string[] GetRolesForUser(string username)
        {
            using (var context = new MainContext())
            {
                return context.Employees.Single(e => e.Login == username).IsAdmin
                           ? new[] { CmmRoles.Administrator, CmmRoles.User }
                           : new[] { CmmRoles.User };
            }
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotSupportedException();
        }
       
        public override void CreateRole(string roleName)
        {
            throw new NotSupportedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotSupportedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotSupportedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotSupportedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotSupportedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotSupportedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotSupportedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotSupportedException();
        }       
    }
}