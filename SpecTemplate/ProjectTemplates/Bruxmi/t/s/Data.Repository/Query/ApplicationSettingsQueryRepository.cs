using Core.Interfaces;
using Core.Interfaces.Repository.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Query
{
    public class ApplicationSettingsQueryRepository<T> : QueryRepositoryBase<T>, IApplicationSettingsQueryRepository<T>
        where T : class, IEntity
    {
        public ApplicationSettingsQueryRepository(IRepositoryApplicationSettingInitializer<T> initializer)
			: base(initializer)
		{
        }
    }
}
