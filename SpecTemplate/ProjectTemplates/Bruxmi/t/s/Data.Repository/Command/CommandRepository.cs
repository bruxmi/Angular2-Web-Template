using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Command
{
    public class CommandRepository<T> : CommandRepositoryBase<T>
        where T : class, IEntity
    {
        public CommandRepository(DbContext context)
            : base(context)
        {
        }
    }
}
