using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailsDTO :IDTO
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentTime { get; set; }
        public DateTime ReturnTime { get; set; }
    }
}
