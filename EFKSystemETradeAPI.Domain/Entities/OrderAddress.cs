using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class OrderAddress : BaseEntity
    {
        public Address Address { get; set; }
        public string OrderAddressType { get; set; }
    }
}
