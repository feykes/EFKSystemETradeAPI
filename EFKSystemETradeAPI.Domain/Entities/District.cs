using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class District : BaseEntity
    {
        public string DistrictName { get; set; }
        public Province Province { get; set; }
    }
}
