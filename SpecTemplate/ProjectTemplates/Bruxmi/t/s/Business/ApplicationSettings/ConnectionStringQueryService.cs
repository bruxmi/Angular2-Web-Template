using Core.Entities.Application;
using Core.Interfaces.Repository.Query;
using Core.Interfaces.Services.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ApplicationSettings
{
    public class ConnectionStringQueryService : IConnectionStringQueryService
    {
        private readonly IApplicationSettingsQueryRepository<ConnectionString> connectionStringRepository;

        public ConnectionStringQueryService(IApplicationSettingsQueryRepository<ConnectionString> connectionStringRepository)
        {
            this.connectionStringRepository = connectionStringRepository;
        }

        public async Task<List<ConnectionString>> GetAllConnectionStringsAsync()
        {
            var result = await this.connectionStringRepository.GetAllAsync();
            return result;
        }
    }
}
