using Core.Interfaces.Repository.Command;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Command
{
    public class DynamicSqlCommandRepository : IDynamicSqlCommandRepository
    {
        public DynamicSqlCommandRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public DbContext DbContext { get; }

        public async Task<int> SqlCommandAsync(string sql, params object[] parameters)
        {
            if (string.IsNullOrEmpty(sql))
            {
                throw new ArgumentNullException(nameof(sql));
            }
            var result = await DbContext.Database.ExecuteSqlCommandAsync(sql, parameters);
            return result;
        }
    }

}
