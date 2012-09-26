using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fit;
using Patterns.Examples;

namespace PatternsFixture
{
    public class PlayerRegisters : ColumnFixture
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public decimal Balance { get; set; }

        public int PlayerId()
        {
            var reg = new PlayerRegistrationInfo
            {
                UserName = Username,
                Password = Password,

            };

            return SetUpTestEnvironment.playerManager.RegisterPlayer(reg);
        }
    }

    public class CheckStoredDetails : ColumnFixture
    {
        public int PlayerId;
        public string Username
        {
            get
            {
                return SetUpTestEnvironment.playerManager.GetPlayer(PlayerId).UserName;
            }
        }
        public decimal Balance
        {
            get
            {
                return SetUpTestEnvironment.playerManager.GetPlayer(PlayerId).Balance;
            }
        }
    }

    public class CheckLogIn : ColumnFixture
    {
        public string Username;
        public string Password;
        public bool CanLogIn()
        {
            int id = SetUpTestEnvironment.playerManager.LogIn(Username, Password);
            return (id > -1);
        }
    }
}
