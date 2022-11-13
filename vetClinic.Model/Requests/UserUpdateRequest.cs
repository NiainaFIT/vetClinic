using System;
using System.Collections.Generic;
using System.Text;

namespace vetClinic.Model.Requests
{
    public class UserUpdateRequest : BaseRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Jmbg { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }  
    }
}
