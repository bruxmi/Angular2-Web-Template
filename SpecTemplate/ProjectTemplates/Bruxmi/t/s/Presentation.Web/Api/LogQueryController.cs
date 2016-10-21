using Core.Entities.Application;
using Core.Interfaces.Services.Query;
using Presentation.Web.Api.Base;
using Presentation.Web.MappingServices.Interfaces.Base;
using Presentation.Web.ViewModels.Log;
using System.Threading.Tasks;
using System.Web.Http;

namespace Angular2.Api
{
    public class LogQueryController : BaseApiController<ILogQueryService, IMappingGetService<Log, LogGetVm>>
    {
        public async Task<IHttpActionResult> Put(LogPagingGetVm vm)
        {
            var count = await this.BusinessService.GetLogsCountAsync(vm.SearchTerm);
            var logs = await this.BusinessService.GetLogsWithPagingAsync(vm.PageIndex, vm.PageSize, vm.IsDescending, vm.SearchTerm);
            vm.Logs = await this.MappingService.EntityToGetVmAsync(logs);
            vm.Count = count;
            return Ok(vm);
        }
    }
}
