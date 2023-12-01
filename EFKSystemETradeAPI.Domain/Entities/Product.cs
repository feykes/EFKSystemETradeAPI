using EFKSystemETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public Collection? Collection { get; set; }
        public Season? Season { get; set; }
        public string? Description { get; set; }
        public Color Color { get; set; }
        public long Price { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public float? AvgScore { get; set; }
        public ProductGroup? ProductGroup { get; set; }
        public Size Size { get; set; }
        public ICollection<ProductImage>? Images { get; set; }
        public Category Category { get; set; }
        public SubCategory? SubCategory { get; set; }
        public bool InStock { get; set; }
    }
}
