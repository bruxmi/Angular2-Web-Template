using Core.Interfaces;
using Core.Interfaces.Repository.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Query
{
    public class QueryRepository<T> : QueryRepositoryBase<T>
        where T : class, IEntity
    {
        public QueryRepository(IRepositoryInitializer<T> initializer) :
            base(initializer)
        {
        }
    }
}
