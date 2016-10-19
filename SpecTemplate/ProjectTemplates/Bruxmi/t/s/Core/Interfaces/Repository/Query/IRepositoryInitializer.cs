using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository.Query
{
    public interface IRepositoryInitializer<T>
            where T : class, IEntity
    {
        DbSet<T> GetDbSet();
    }
}
