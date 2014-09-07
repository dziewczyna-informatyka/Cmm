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
            return second != null && second.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
