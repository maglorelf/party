namespace party.service
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ManageService : IManageService
    {
        public ManageService()
        {

        }

        public void CreateEventRepository(string repositoryPath)
        {
            if (string.IsNullOrEmpty(repositoryPath))
            {
                //     repositoryPath=System.app.
            }
        }
    }
}
