using EFKSystemETradeAPI.Application.Repositories;
using EFKSystemETradeAPI.Domain.Entities;
using EFKSystemETradeAPI.Persistence.Contexts;
using EFKSystemETradeAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Persistence
{
    public class ProvinceWriteRepository : WriteRepository<Province>, IProvinceWriteRepository
    {
        private readonly ApplicationDbContext _context;
        public ProvinceWriteRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> AddRangeAsync(List<Province> entity)
        {
            await _context.AddRangeAsync(entity);
            return true;
        }
    }
}
