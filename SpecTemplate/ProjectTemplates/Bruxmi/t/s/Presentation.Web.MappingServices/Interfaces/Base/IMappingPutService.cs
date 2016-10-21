using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Web.MappingServices.Interfaces.Base
{
    public interface IMappingPutService<TEntity, TPutVm>
    {
        Task<List<TEntity>> PutVmToEntityAsync(List<TPutVm> vms);

        Task<TEntity> PutVmToEntityAsync(TPutVm vm);
    }
}
