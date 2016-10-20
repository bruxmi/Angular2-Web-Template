using Core.Interfaces.Services.Query;
using Presentation.Web.Api.Base;
using System.Threading.Tasks;
using System.Web.Http;

namespace Angular2.Api
{
    public class LogQueryController : BaseApiController<ILogQueryService>
    {
        public async Task<IHttpActionResult> GetLogs()
        {
            return Ok(await this.Service.GetLogs());
        }
    }
}
