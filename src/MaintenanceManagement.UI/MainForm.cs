﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MaintenanceManagement.DataAccess;
using MaintenanceManagement.DataAccess.Entities;



namespace MaintenanceManagement.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }   
    
        /* ----------------------------------------------------------------------------- */

        private void narzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ToolsList();
            form.ShowDialog();
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeesList();
            form.ShowDialog();
        }

        private void obszaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AreasList();
            form.ShowDialog();
        }

        /* ----------------------------------------------------------------------------- */

        private void noweToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            var form = new TaskEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MainContext())
                {
                    var task = form.EmployeeTask;

                    task.Area = context.Areas.SingleOrDefault(a => a.Id == task.Area.Id);
                    task.Assignee = context.Employees.SingleOrDefault(e => e.Id == task.Assignee.Id);

                    context.EmployeeTasks.Add(task);
                    context.SaveChanges();
                }

            }
        }

        private void aktualneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.InProgress };
            form.ShowDialog();
        }

        private void zaplanowaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Planned };
            form.ShowDialog();
        }

        private void zrealizowaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksList { EmployeeTaskStatus = EmployeeTaskStatus.Done };
            form.ShowDialog();
        }

        private void zestawienieZbiorczeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TasksSummaryList();
            using (var context = new MainContext())
            {
                form.TasksAmount = context.EmployeeTasks.Count();
                form.ActualTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.InProgress);
                form.PlannedTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Planned);
                form.DoneTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Done);
            }
            form.ShowDialog();
        }

        //-----------------------------------------------------------------------------

        private void employeeExample_Click(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                Address = "adjadja",
                EmploymentStart = new DateTime(2012, 11, 14),
                PersonalNumber = 1234,
                EmploymentType = EmploymentType.Clinico,
                Id = 0,
                Name = "Przykładowy",
                Surname = "pracownik",
            };
            var form = new EmployeeTaskSummary();


            using (var context = new MainContext())
            {
                form.AssignedEmployee = emp;
                form.TasksAmount = context.EmployeeTasks.Count(a => a.Assignee.Id == emp.Id);
                form.ActualTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.InProgress && a.Assignee.Id == emp.Id);
                form.PlannedTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Planned && a.Assignee.Id == emp.Id);
                form.DoneTasksAmount = context.EmployeeTasks.Count(a => a.Status == EmployeeTaskStatus.Done && a.Assignee.Id == emp.Id);
            }

            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

       



    }
}
