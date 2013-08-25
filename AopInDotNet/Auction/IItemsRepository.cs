using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.Auction
{
    public interface IItemsRepository
    {
        void AddItem(Item newItem);
        Item FetchByID(int itemID);
        IList<Item> ListItems(int pageSize, int pageIndex);
        void SubmitChanges();
    }
}
