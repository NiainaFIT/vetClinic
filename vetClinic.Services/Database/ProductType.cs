using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int ProductTypeId { get; set; }
        public string ProductName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
