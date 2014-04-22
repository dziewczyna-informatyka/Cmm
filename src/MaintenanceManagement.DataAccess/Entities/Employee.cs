using System;

namespace MaintenanceManagement.DataAccess.Entities
{
    /// <summary>
    /// Klasa pracownik
    /// </summary>
    public class Employee : BaseEntity
    {
        public int? PersonalNumber { get; set; }

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
    }
}
