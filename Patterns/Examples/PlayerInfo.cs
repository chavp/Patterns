using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public class PlayerInfo : PlayerRegistrationInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public decimal Balance { get; set; }
    }
}
