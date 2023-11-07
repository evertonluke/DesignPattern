using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State.RealWorld
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.00);
            account.Deposit(300.00);
            account.Deposit(550.00);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            // Wait for user
            Console.ReadKey();
        }
    }
}
