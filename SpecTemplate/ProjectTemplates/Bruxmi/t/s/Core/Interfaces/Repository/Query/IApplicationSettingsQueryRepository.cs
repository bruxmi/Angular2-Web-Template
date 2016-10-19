using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository.Query
{
    public interface IApplicationSettingsQueryRepository<T> : IQueryRepository<T>
        where T : class, IEntity
    {
    }
}
