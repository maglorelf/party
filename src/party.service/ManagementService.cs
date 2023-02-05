namespace party.service
{
    using party.service.data;

    public class ManagementService : IManagementService
    {
        IDataService dataService;
        public ManagementService(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public void GenerateEvent()
        {
            dataService.InitializeDatabase();
        }
    }
}
