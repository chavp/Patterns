using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public class DrawManager : IDrawManager
    {
        IPlayerManager playerManager;
        IDictionary<string, Draw> mDraw = new Dictionary<string, Draw>();
        public Draw GetDraw(DateTime date)
        {
            CreateDraw(date);
            return mDraw[date.ToString("dd/MM/yyyy")];
        }

        public DrawManager()
        {
        }
        public DrawManager(IPlayerManager pm)
        {
            playerManager = pm;
        }
        public Draw CreateDraw(DateTime drawDate)
        {
            var d = new Draw
            {
                DrawDate = drawDate,
                IsOpen = true,
            };
            string key = drawDate.ToString("dd/MM/yyyy");
            if (!mDraw.ContainsKey(key))
            {
                mDraw.Add(key, d);
            }
            return mDraw[key];
        }

        public void PurchaseTicket(DateTime drawDate, PlayerInfo player, int[] numbers, decimal value)
        {
            var d = GetDraw(drawDate);
            var t = new Ticket
            {
                Holder = player,
                Numbers = numbers,
                Value = value,
            };

            d.AddTicket(t);
            d.TotalPoolSize += value;
            
            player.Balance -= value;
        }

        #region IDrawManager Members

        decimal operatorTakes = 0.5M;
        decimal sixWinner = 0.68M;
        decimal split = 0.1M;

        public void SettleDraw(DateTime drawDate, int[] numbers)
        {
            Draw d = GetDraw(drawDate);

            decimal operatorTakesCost = d.TotalPoolSize - d.TotalPoolSize * operatorTakes;
            decimal prize = operatorTakesCost * sixWinner;
            //foreach (var t in d.Tickets)
            //{
            //    netPrize += t.Value
            //}
            int winner = 0;
            foreach (var t in d.Tickets)
            {
                int score = 0;
                foreach (var number in numbers)
                {
                    score += (t.Numbers.Contains(number)) ? 1 : 0;
                }
                if (score > 0)
                {
                    ++winner;
                }

                t.Score = score;
            }

            if (winner == 1)
            {
                split = 0;
            }

            foreach (var t in d.Tickets)
            {
                if (t.Score > 0)
                {
                    t.Holder.Balance = t.Holder.Balance + prize * (t.Score / numbers.Length) + t.Value * split;
                }
            }
        }

        #endregion
    }
}
