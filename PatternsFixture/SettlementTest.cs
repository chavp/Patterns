using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Patterns.Examples;
using fit;
using fitlibrary;

namespace PatternsFixture
{
    public class SettlementTest : DoFixture
    {
        private IDrawManager drawManager;
        private IPlayerManager playerManager;
        private DateTime drawDate;
        public SettlementTest()
        {
            playerManager = new PlayerManager();
            drawManager = new DrawManager(playerManager);
            drawDate = DateTime.Now;
            drawManager.CreateDraw(drawDate);
        }

        public Fixture AccountsBeforeTheDraw()
        {
            return new CreatePlayerFixture(playerManager);
        }

        public Fixture TicketsInTheDraw()
        {
            return new TicketPurchaseFixture(playerManager, drawManager, drawDate);
        }
        public Fixture AccountsAfterTheDraw()
        {
            return new BalanceCheckFixture(playerManager);
        }

        public void DrawResultsAre(int[] numbers)
        {
            drawManager.SettleDraw(drawDate, numbers);
        }
    }

    internal class CreatePlayerFixture : SetUpFixture
    {
        private IPlayerManager _playerManager;
        public CreatePlayerFixture(IPlayerManager pm)
        {
            _playerManager = pm;
        }

        public void PlayerBalance(String player, decimal balance)
        {
            PlayerRegistrationInfo p = new PlayerRegistrationInfo();
            p.UserName = player;
            p.Name = player;
            p.Password = "XXXXXX";
            int playerId = _playerManager.RegisterPlayer(p);
            _playerManager.AdjustBalance(playerId, balance);
        }
    }
    internal class TicketPurchaseFixture : SetUpFixture
    {
        private IDrawManager _drawManager;
        private DateTime _drawDate;
        private IPlayerManager _playerManager;
        public TicketPurchaseFixture(IPlayerManager pm, IDrawManager dm, DateTime drawDate)
        {
            _drawManager = dm;
            _playerManager = pm;
            _drawDate = drawDate;
        }
        public void PlayerNumbersValue(String player, int[] numbers, decimal value)
        {
            _drawManager.PurchaseTicket(_drawDate, _playerManager.GetPlayer(player), numbers, value);
        }
    }
    internal class BalanceCheckFixture : ColumnFixture
    {
        private IPlayerManager _playerManager;
        public BalanceCheckFixture(IPlayerManager pm)
        {
            _playerManager = pm;
        }
        public String player;
        public decimal Balance
        {
            get
            {
                return _playerManager.GetPlayer(player).Balance;
            }
        }
    }
}
