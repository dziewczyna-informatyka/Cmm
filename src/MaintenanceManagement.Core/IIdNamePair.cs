namespace MaintenanceManagement.Core
{
    public interface IIdNamePair : IIdentifiable
    {        
        string Name { get; }
    }
}