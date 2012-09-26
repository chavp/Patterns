using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fitlibrary;
using Patterns.Examples;

namespace PatternsFixture
{
    public class PurchaseTicket : DoFixture
    {
        public void PlayerDepositsDollarsWithCardAndExpiryDate(
            string username, decimal amount, string card, string expiry)
        {
            int pid = SetUpTestEnvironment.playerManager.GetPlayer(username).ID;
            SetUpTestEnvironment.playerManager.DepositWithCard(pid, card, expiry, amount);
        }
        public bool PlayerHasDollars(String username, decimal amount)
        {
            return (SetUpTestEnvironment.playerManager.GetPlayer(username).Balance == amount);
        }
        public void PlayerBuysATicketWithNumbersForDrawOn(string username, int[] numbers, DateTime date)
        {
            PlayerBuysTicketsWithNumbersForDrawOn(username, 1, numbers, date);
        }
        public void PlayerBuysATicketWithNumbersForDollarsForDrawOn(
            string username, int[] numbers, decimal amount, DateTime date
            )
        {
        }
        private void PlayerBuysTicketsWithNumbersForDrawOn(string username, int tickets, int[] numbers, DateTime date)
        {
            var p = SetUpTestEnvironment.playerManager.GetPlayer(username);
            SetUpTestEnvironment.drawManager.PurchaseTicket(date, p, numbers, 10 * tickets);
            
        }
        public decimal PoolValueForDrawOnIs(DateTime date)
        {
            return SetUpTestEnvironment.drawManager.GetDraw(date).TotalPoolSize;
        }
        public decimal AccountBalanceForHas(String username)
        {
            return SetUpTestEnvironment.playerManager.GetPlayer(username).Balance;
        }

        private static bool CompareArrays(int[] sorted1, int[] unsorted2)
        {
            if (sorted1.Length != unsorted2.Length) return false;
            Array.Sort(unsorted2);
            for (int i = 0; i < sorted1.Length; i++)
            {
                if (sorted1[i] != unsorted2[i]) return false;
            }
            return true;
        }
        public bool TicketWithNumbersForDollarsIsRegisteredForPlayerForDrawOn(
            int[] numbers, decimal amount, string username, DateTime draw)
        {
            var tck = SetUpTestEnvironment.drawManager.GetDraw(draw).Tickets;
            Array.Sort(numbers);
            foreach (Ticket ticket in tck)
            {
                if (CompareArrays(numbers, ticket.Numbers) &&
                    amount == ticket.Value &&
                    username.Equals(ticket.Holder.UserName))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
