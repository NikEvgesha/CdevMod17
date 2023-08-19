using CdevMod17.Accounts;

namespace CdevMod17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAccount> accounts = new List<IAccount>();

            accounts.Add(new CommonAccount(1500));
            accounts.Add(new CommonAccount(500));
            accounts.Add(new SalaryAccount(1000));
            
            foreach (var account in accounts)
            {
                Calculator.CalculateInterest(account);
                Console.WriteLine($"Тип аккаунта: {account.Type}. Результат расчета: {account.Interest}");
            }


        }
    }
}