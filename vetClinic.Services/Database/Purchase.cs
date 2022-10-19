using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseItems = new HashSet<PurchaseItem>();
        }

        public int PurchaseId { get; set; }
        public string PurchaseReceiptNo { get; set; } = null!;
        public DateTime DateOfPurchase { get; set; }
        public decimal PurchaseInvoice { get; set; }
        public decimal Pdv { get; set; }
        public string? Napomena { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
    }
}
