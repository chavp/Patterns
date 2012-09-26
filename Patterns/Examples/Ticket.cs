using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public class Ticket
    {
        public int[] Numbers { get; internal set; }
        public PlayerInfo Holder { get; internal set; }
        public decimal Value { get; internal set; }

        public int Score { get; set; }
    }
}
