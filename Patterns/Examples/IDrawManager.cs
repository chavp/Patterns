using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public interface IDrawManager
    {
        Draw GetDraw(DateTime date);
        Draw CreateDraw(DateTime drawDate);
        void PurchaseTicket(DateTime drawDate, PlayerInfo player, int[] numbers, decimal value);

        void SettleDraw(DateTime drawDate, int[] numbers);
    }
}
