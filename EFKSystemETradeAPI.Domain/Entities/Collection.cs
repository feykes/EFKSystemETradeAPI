using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class Collection : BaseEntity
    {
        public string CollectionName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Season? Season { get; set; }
    }
}
