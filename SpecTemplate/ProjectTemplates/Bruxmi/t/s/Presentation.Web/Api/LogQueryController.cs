using Core.Entities.Application;
using Core.Interfaces.Services.Query;
using Presentation.Web.Api.Base;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Angular2.Api
{
    public class LogQueryController : BaseApiController<ILogQueryService>
    {
        public async Task<IHttpActionResult> Put(LogPagingVm vm)
        {
            var count = await this.Service.GetLogsCountAsync(vm.SearchTerm);
            var logs = await this.Service.GetLogsWithPagingAsync(vm.PageIndex, vm.PageSize, vm.IsDescending, vm.SearchTerm);
            vm.Logs = logs;
            vm.Count = count;
            return Ok(vm);
        }

        public class LogPagingVm
        {
            public LogPagingVm()
            {
                this.Logs = new List<Log>();
            }
            public int Count { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public string SearchTerm { get; set; }
            public bool IsDescending { get; set; }
            public List<Log> Logs { get; set; }
        }
    }
}
