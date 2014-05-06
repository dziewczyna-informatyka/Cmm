﻿using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.Core;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Migrations;
using MaintenanceManagement.UI.Core;

namespace MaintenanceManagement.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginWindow = new LoginWindow();

            if (loginWindow.ShowDialog() == DialogResult.OK)
            {               
                using (var context = new MainContext())
                {
                    var hash = HashHelper.GetHash(loginWindow.Password);
                    UserContext.User =
                        context.Employees.SingleOrDefault(
                            e =>
                                e.Login == loginWindow.Login &&
                                e.PasswordHash == hash);
                }

                if (UserContext.User != null)
                {
                    Application.Run(new MainWindow());
                }
                else
                {
                    MessageBox.Show("Zle haslo lub uzytkownik", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
