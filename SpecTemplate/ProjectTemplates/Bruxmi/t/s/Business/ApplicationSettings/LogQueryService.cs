using Core.Interfaces.Services.Query;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Application;
using Core.Interfaces.Repository.Query;

namespace Business.ApplicationSettings
{
    public class LogQueryService : ILogQueryService
    {

        private readonly IApplicationSettingsQueryRepository<Log> logRepository;

        public LogQueryService(IApplicationSettingsQueryRepository<Log> logRepository)
        {
            this.logRepository = logRepository;
        }
        public async Task<List<Log>> GetLogs()
        {
            return await this.logRepository.GetAllAsync();
        }
    }
}
