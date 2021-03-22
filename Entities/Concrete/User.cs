using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User:Customer
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
