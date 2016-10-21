using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Web.MappingServices.Interfaces.Base
{
    public interface IMappingGetService<TEntity, TGetVm>
    {
        Task<List<TGetVm>> EntityToGetVmAsync(List<TEntity> entities);

        Task<TGetVm> EntityToGetVmAsync(TEntity entity);
    }
}
