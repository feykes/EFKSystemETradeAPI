using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string OrderCode { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
        public long Price { get; set; }
        public Status Status { get; set; }
        public string? CargoTrackingNumber { get; set; }
        public string? CargoCompany { get; set; }
        public string PaymentMethod { get; set; }
        public long ShippingPrice { get; set; }
        public long TotalPrice { get; set; }
        public ICollection<OrderAddress> OrderAddresses { get; set; }
    }
}
