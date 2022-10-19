using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Order
    {
        public Order()
        {
            OrderInvoices = new HashSet<OrderInvoice>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Status { get; set; }
        public bool? IsCanceled { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<OrderInvoice> OrderInvoices { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
