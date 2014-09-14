namespace MaintenanceManagement.Web.Models.Api
{
    using MaintenanceManagement.Core;

    public class EmployeeGetModel : IIdNamePair
    {
        public int Id { get; set; }

        public int? PersonalNumber { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string EmploymentStart { get; set; }

        public string Address { get; set; }

        public string MobilePhone { get; set; }

        public string HomePhone { get; set; }

        public IdNamePair JobTitle { get; set; }

        public IdNamePair EmploymentType { get; set; }

        public string Login { get; set; }

        public IdNamePair WorkSchedule { get; set; }

        public IdNamePair Area { get; set; }

        public IdNamePair Team { get; set; }

        public bool IsAdmin { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.Surname);
            }
        }
    }
}