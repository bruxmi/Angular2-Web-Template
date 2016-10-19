using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository.Command
{
    public interface IDeleteCommandRepository<T>
        where T : class
    {
        Task DeleteAsync(T entity);

        Task DeleteListAsync(ICollection<T> entityList);

    }
}
