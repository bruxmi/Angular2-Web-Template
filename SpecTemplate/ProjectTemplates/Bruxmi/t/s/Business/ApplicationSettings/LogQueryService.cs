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

        public async Task<int> GetLogsCountAsync(string searchTerm)
        {
            if (searchTerm == "All")
            {
                return await this.logRepository.CountAsync();
            }
            return await this.logRepository.CountAsync(s => s.Level == searchTerm);
        }

        public async Task<List<Log>> GetLogsWithPagingAsync(int pageIndex, int pageSize, bool isDescending, string searchTerm)
        {
            if (searchTerm == "All")
            {
                return await this.logRepository.GetAllWithPagingAsync(l => l.Id, pageIndex, pageSize);
            }
            return await this.logRepository.GetFilteredtWithPagingAndOrderAsync(l => l.Level == searchTerm, l => l.Id, pageIndex, pageSize);
        }
    }
}
