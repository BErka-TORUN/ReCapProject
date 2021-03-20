using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsDTO : IDTO
    {
        public int CarId { get; set; }
        public char CarName { get; set; }
        public int ColorId { get; set; }
        public char ColorName { get; set; }
    }
}
