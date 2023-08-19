using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CdevMod17.Accounts
{
    public class SalaryAccount : IAccount
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public SalaryAccount(double balance)
        {
            Type = "Зарплатный";
            Balance = balance;
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
