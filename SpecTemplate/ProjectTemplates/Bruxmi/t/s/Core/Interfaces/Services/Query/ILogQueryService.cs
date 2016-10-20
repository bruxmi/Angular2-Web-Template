using Core.Entities.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services.Query
{
    public interface ILogQueryService
    {
        Task<List<Log>> GetLogs();

        Task<List<Log>> GetLogsWithPagingAsync(int pageIndex, int pageSize, bool isDescending, string searchTerm);

        Task<int> GetLogsCountAsync();
    }
}
