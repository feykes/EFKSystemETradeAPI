using EFKSystemETradeAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Application.Repositories
{
    public interface IProvinceWriteRepository : IWriteRepository<Province>
    {
        Task<bool> AddRangeAsync(List<Province> entity);
    }
}
