using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.Auction
{
    public class Item
    {
        private List<Bid> _Bids;

        public Item()
        {
            _Bids = new List<Bid>();
        }

        public void AddBid(Member m, decimal amount)
        {

        }

        public int ID { get; protected set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AuctionEndDate { get; set; }

        public IList<Bid> Bids 
        {
            get
            {
                return _Bids.AsReadOnly();
            }
            protected set
            {
                _Bids.AddRange(value);
            }
        }
    }
}
