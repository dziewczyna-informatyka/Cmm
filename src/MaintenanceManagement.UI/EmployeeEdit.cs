﻿using System;
using System.Linq;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;
using MaintenanceManagement.UI.Core;

namespace MaintenanceManagement.UI
{
    public partial class EmployeeEdit : Form
    {
        public EmployeeEdit()
        {
            InitializeComponent();

            LoadEmploymentTypes();

            LoadAreas();

            LoadTeams();
        }

        public Employee Employee
        {
            get
            {
                int number = 0;

                return new Employee()
                {
                    Name = employeeName.Text,
                    Surname = employeeSurname.Text,
                    PersonalNumber = int.TryParse(employeePersonalNr.Text, out number) ? number : 0,
                    Address = employeeAdress.Text,
                    EmploymentStart = employeeEmploymentStart.Value.Date,
                    EmploymentType = (EmploymentType)employeeEmploymentType.SelectedItem,
                    MobilePhone = employeeMobilePhone.Text,
                    HomePhone = employeePhone.Text,
                    Area = (Area)employeeArea.SelectedItem,
                    Team = (Team)employeeTeam.SelectedValue,
                    PasswordHash = txtPassword.Text,
                    Login = string.Format("{0}{1}", employeeName.Text.Substring(0, 3), employeeSurname.Text.Substring(0, 3))

                };
            }

            set
            {
                employeeName.Text = value.Name;
                employeeSurname.Text = value.Surname;
                employeePersonalNr.Text = value.PersonalNumber.ToString();
                employeeAdress.Text = value.Address;

                if (value.EmploymentStart != null)
                {
                    employeeEmploymentStart.Value = value.EmploymentStart.GetValueOrDefault();
                }

                employeeEmploymentType.SelectedItem = value.EmploymentType;
                employeeMobilePhone.Text = value.MobilePhone;
                employeePhone.Text = value.HomePhone;
                employeeArea.SelectedItem = value.Area;
                employeeTeam.SelectedValue = value.Team;
            }
        }

        private void LoadTeams()
        {
            employeeTeam.LoadEnumAsDataSource(typeof(Team));
        }

        private void LoadEmploymentTypes()
        {
            employeeEmploymentType.Items.Clear();

            employeeEmploymentType.DataSource = Enum.GetValues(typeof(EmploymentType));
        }

        private void LoadAreas()
        {
            employeeArea.Items.Clear();

            using (var context = new MainContext())
            {
                employeeArea.DataSource = context.Areas.ToList();
            }

        }



    }
}
