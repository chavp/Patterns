using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.Auction
{
    public interface IMembersRepository
    {
        void AddMember(Member newMember);
        Member FetchByLoginName(string loginName);
        void SubmitChanges();
    }
}
