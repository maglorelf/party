namespace party.service
{
    using party.core.infrastructure;

    public interface IManagementService
    {
        ResultValue<string> GenerateEvent();
    }
}
