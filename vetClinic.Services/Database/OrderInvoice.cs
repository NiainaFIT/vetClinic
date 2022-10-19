using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class OrderInvoice
    {
        public OrderInvoice()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }

        public int OrderInvoiceId { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public DateTime DateOfInvoice { get; set; }
        public int UserId { get; set; }
        public bool Signed { get; set; }
        public decimal TotalWithoutPdv { get; set; }
        public decimal TotalWithPdv { get; set; }
        public int? OrderId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
