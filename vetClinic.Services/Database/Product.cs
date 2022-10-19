using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Product
    {
        public Product()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            OrderItems = new HashSet<OrderItem>();
            PurchaseItems = new HashSet<PurchaseItem>();
            Reviews = new HashSet<Review>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
        public int ProductType { get; set; }
        public int UnitOfMeasure { get; set; }
        public string? ImagePath { get; set; }
        public string? ThumbPath { get; set; }
        public bool? Status { get; set; }

        public virtual ProductType ProductTypeNavigation { get; set; } = null!;
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
