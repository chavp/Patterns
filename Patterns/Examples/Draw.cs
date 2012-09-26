using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples
{
    public class Draw
    {
        public Draw()
        {
            Tickets = new List<Ticket>();
        }

        public DateTime DrawDate { get; internal set; }
        public bool IsOpen { get; internal set; }
        public decimal TotalPoolSize { get; internal set; }
        public IList<Ticket> Tickets { get; internal set; }
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
