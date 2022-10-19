using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateReviewed { get; set; }
        public int Mark { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
