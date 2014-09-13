namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq.Expressions;

    using MaintenanceManagement.Core.Resources;

    /// <summary>
    /// Klasa pracownik
    /// </summary>
    public class Employee : BaseEntity
    {
        [Index(IsUnique = true)]
        public int? PersonalNumber { get; set; }

          [Display(ResourceType = typeof(Common), Name = "Employee_Name")]
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? EmploymentStart { get; set; }

        public string Address { get; set; }

        public string MobilePhone { get; set; }

        public string HomePhone { get; set; }

        public JobTitle? JobTitle { get; set; }

        public EmploymentType? EmploymentType { get; set; }

        public string Login { get; set; }

        public string PasswordHash { get; set; }

        public WorkSchedule? WorkSchedule { get; set; }

        public Area Area { get; set; }

        public Team Team { get; set; }

        public bool IsAdmin { get; set; }

        public Func<Employee, string> FullName
        {
            get { return e => e.Name + " " + e.Surname; }
        }
    }
}
