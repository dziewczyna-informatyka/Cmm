using System.Runtime.Remoting.Messaging;

namespace MaintenanceManagement.DataAccess.Entities
{
    /// <summary>
    /// Encja bazowa
    /// </summary>
    /// <remarks>
    /// Zawiera w sobie wszystkie wspólne wlasciwosci
    /// </remarks>
    public class BaseEntity
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var second = obj as BaseEntity;
            return second != null && second.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
