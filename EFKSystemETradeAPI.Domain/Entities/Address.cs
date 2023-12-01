using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string AddressText { get; set; }
        public Province Province { get; set; }
        public District District { get; set; }
        public string? PostalCode { get; set; }
        public Customer Customer { get; set; }
    }
}
