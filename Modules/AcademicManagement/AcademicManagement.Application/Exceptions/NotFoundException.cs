namespace AcademicManagement.Application.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException(string entityName, object entityId)
        : base($"{entityName} with ID '{entityId}' not found")
    {
        EntityName = entityName;
        EntityId = entityId;
    }

    public string EntityName { get; }
    public object EntityId { get; }
}
