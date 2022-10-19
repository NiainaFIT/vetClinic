using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public int OrderInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }

        public virtual OrderInvoice OrderInvoice { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
