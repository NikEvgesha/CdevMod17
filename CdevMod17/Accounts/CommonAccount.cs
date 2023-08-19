using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CdevMod17.Accounts
{
    public class CommonAccount : IAccount
    {
        public string Type { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }

        public CommonAccount(double balance)
        {
            Type = "Обычный";
            Balance = balance;
        }
        
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;

        }
    }
}
