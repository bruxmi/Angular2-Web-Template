using Core.Entities.Application;
using Presentation.Web.MappingServices.Interfaces.Base;
using Presentation.Web.ViewModels.Log;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Web.MappingServices.Services
{
    public class LogMappingService : IMappingGetService<Log, LogGetVm>
    {
        public async Task<LogGetVm> EntityToGetVmAsync(Log entity)
        {
            return await Task.FromResult(
                new LogGetVm
                {
                    Exception = entity.Exception,
                    Level = entity.Level,
                    Id = entity.Id,
                    Message = entity.Message,
                    RequestId = entity.RequestId,
                    TimeStamp = entity.TimeStamp,
                    UserName = entity.UserName
                });
        }

        public async Task<List<LogGetVm>> EntityToGetVmAsync(List<Log> entities)
        {
            var result = new List<LogGetVm>();
            foreach (var entity in entities)
            {
                result.Add(await this.EntityToGetVmAsync(entity));
            }
            return result;
        }
    }
}
