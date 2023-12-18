using EFKSystemETradeAPI.Application.Repositories;
using EFKSystemETradeAPI.Domain.Entities;
using EFKSystemETradeAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Persistence.Repositories
{
    public class ProductImageReadRepository : ReadRepository<ProductImage>, IProductImageReadRepository
    {
        public ProductImageReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
