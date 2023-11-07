using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State.RealWorld
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    public class GoldState : State
    {
        public GoldState(State state) : this(state.Balance, state.Account)
        {
            
        }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should com from a datasource

            interest = 0.0;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
