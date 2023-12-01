using EFKSystemETradeAPI.Application.Repositories;
using EFKSystemETradeAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRespository<T> where T : BaseEntity
    {
        public DbSet<T> Table => throw new NotImplementedException();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            throw new NotImplementedException();
        }
    }
}
