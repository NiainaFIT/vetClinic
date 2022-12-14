using System;
using System.Collections.Generic;
using System.Text;

namespace vetClinic.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int ProductType { get; set; }
        public int UnitOfMeasure { get; set; }
        public string ImagePath { get; set; }
        public string ThumbPath { get; set; }
        public bool Status { get; set; }
    }
}
