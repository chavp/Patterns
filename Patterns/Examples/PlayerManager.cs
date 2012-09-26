using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public class PlayerManager : IPlayerManager
    {
        IList<PlayerRegistrationInfo> mPlayerRegistrationInfo = new List<PlayerRegistrationInfo>();

        public int RegisterPlayer(PlayerRegistrationInfo p)
        {
            PlayerInfo pInfo = new PlayerInfo
            {
                UserName = p.UserName,
                Password = p.Password,
                Name = p.Name,
            };

            mPlayerRegistrationInfo.Add(pInfo);
            pInfo.ID = mPlayerRegistrationInfo.Count;
            return pInfo.ID;
        }

        public PlayerInfo GetPlayer(int id)
        {
            return (from p in mPlayerRegistrationInfo
                    where p.ID == id
                    select p).SingleOrDefault() as PlayerInfo;
        }

        public PlayerInfo GetPlayer(string username)
        {
            return (from p in mPlayerRegistrationInfo
                    where p.UserName == username
                    select p).SingleOrDefault() as PlayerInfo;
        }

        public int LogIn(string username, string password)
        {
            var p = GetPlayer(username);
            return (p != null && p.Password == password) ? p.ID : -1;
        }

        public void AdjustBalance(int playerId, decimal amount)
        {
            PlayerInfo p = GetPlayer(playerId);
            p.Balance = amount;
        }

        public void DepositWithCard(int playerId, string cardNumber, string expiryDate, decimal amount)
        {
            PlayerInfo p = GetPlayer(playerId);
            p.Balance += amount;
        }

    }
}
