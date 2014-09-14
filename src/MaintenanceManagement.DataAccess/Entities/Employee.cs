namespace MaintenanceManagement.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MaintenanceManagement.Core.Resources;

    /// <summary>
    /// Klasa pracownik
    /// </summary>
    public class Employee : BaseEntity
    {
        [Index(IsUnique = true)]
        [Display(ResourceType = typeof(Common), Name = "Employee_PersonalNumber")]
        public int? PersonalNumber { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_FirstName")]
        public string FirstName { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_Surname")]
        public string Surname { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_EmploymentStart")]
        public DateTime? EmploymentStart { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_Address")]
        public string Address { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_MobilePhone")]
        public string MobilePhone { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_HomePhone")]
        public string HomePhone { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_JobTitle")]
        public JobTitle? JobTitle { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_EmploymentType")]
        public EmploymentType? EmploymentType { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_Login")]
        public string Login { get; set; }

        public string PasswordHash { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_WorkSchedule")]
        public WorkSchedule? WorkSchedule { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_Area")]
        public virtual Area Area { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_Team")]
        public Team Team { get; set; }

        [Display(ResourceType = typeof(Common), Name = "Employee_IsAdmin")]
        public bool IsAdmin { get; set; }

        public Func<Employee, string> FullName
        {
            get { return e => e.FirstName + " " + e.Surname; }
        }
    }
}
