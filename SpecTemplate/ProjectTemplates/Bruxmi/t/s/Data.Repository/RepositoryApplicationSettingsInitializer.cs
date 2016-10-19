using Core.Interfaces;
using Core.Interfaces.Repository.Query;
using Data.ApplicationSettingsContext;

namespace Data.Repository
{
    public class RepositoryApplicationSettingsInitializer<T> : RepositoryBaseInitializer<T>, IRepositoryApplicationSettingInitializer<T>
        where T : class, IEntity
    {
        public RepositoryApplicationSettingsInitializer(AppSettingContext context)
            : base(context)
        {

        }
    }
}
