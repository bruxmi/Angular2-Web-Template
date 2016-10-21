using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Web.MappingServices.Interfaces.Base
{
    public interface IMappingPostService<TEntity, TPostVm>
    {
        Task<List<TEntity>> PostVmToEntityAsync(List<TPostVm> vms);

        Task<TEntity> PostVmToEntityAsync(TPostVm vm);
    }
}
