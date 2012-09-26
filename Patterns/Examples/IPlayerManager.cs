using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public interface IPlayerManager
    {
        int RegisterPlayer(PlayerRegistrationInfo p);
        PlayerInfo GetPlayer(int id);
        PlayerInfo GetPlayer(String username);
        int LogIn(String username, String password);

        void AdjustBalance(int playerId, decimal amount);
        void DepositWithCard(int playerId, String cardNumber, String expiryDate, decimal amount);
    }
}
