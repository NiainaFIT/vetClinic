using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class PurchaseItem
    {
        public int PurchaseItemId { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Purchase Purchase { get; set; } = null!;
    }
}
