using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository.Command
{
    public interface IUpdateCommandRepository<T>
        where T : class
    {
        Task UpdateAsync(T entity);

        Task UpdateListAsync(List<T> entities);
    }
}
