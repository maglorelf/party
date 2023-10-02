namespace party.service
{
    using party.core.infrastructure;
    using party.service.data;

    public class ManagementService : IManagementService
    {
        private readonly IDataService dataService;
        public ManagementService(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public ResultValue<string> GenerateEvent()
        {
            dataService.InitializeDatabase();
            return dataService.CheckDatabase();
        }
    }
}
