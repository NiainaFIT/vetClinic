using System;
using System.Collections.Generic;
using System.Text;

namespace vetClinic.Model.SearchObjects
{
    public class ProductSearchObject : BaseSearchObject
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
    }
}
