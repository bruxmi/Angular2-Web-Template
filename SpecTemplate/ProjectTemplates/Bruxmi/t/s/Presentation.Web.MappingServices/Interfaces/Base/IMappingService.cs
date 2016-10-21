namespace Presentation.Web.MappingServices.Interfaces.Base
{
    public interface IMappingService<TEntity, TGetVm, TPostVm, TPutVm>:
        IMappingGetService<TEntity, TGetVm>, 
        IMappingPostService<TEntity, TPostVm>,
        IMappingPutService<TEntity, TPutVm>

    {
    }
}
