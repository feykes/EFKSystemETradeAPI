using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        public string SubCategoryName { get; set; }
        public Category Category { get; set; }
    }
}
