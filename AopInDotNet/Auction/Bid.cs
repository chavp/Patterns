using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.Auction
{
    public class Bid
    {
        public Member Member { get; set; }
        public DateTime DatePlaced { get; set; }
        public decimal BidAmount { get; set; }
    }
}
