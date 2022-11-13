using System;
using System.Collections.Generic;
using System.Text;

namespace vetClinic.Model.Requests
{
    public class BaseRequest
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public int? ModifiedByUserId { get; set; }
    }
}
