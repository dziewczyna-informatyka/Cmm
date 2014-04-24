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
            var o = obj as BaseEntity;
            return o != null && o.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
