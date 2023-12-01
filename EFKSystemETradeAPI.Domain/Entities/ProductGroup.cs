using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class ProductGroup : BaseEntity
    {
        public string GroupCode { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
