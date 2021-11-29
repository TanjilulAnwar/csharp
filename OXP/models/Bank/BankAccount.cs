using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models
{
    abstract class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }
        // public double ServiceCharge { get; private set; }
        //public double InterestAmount { get; private set; }


        public BankAccount(string accountNo, string customerName):this()
        {
            
            AccountNo = accountNo;
            CustomerName = customerName;
        }
        public BankAccount()
        {
            Balance = 0;
        }

        public string Deposit(double amount)
        {
            this.Balance += amount;
            return "Deposited !";
        }

        public virtual string Withdraw(double amount)
        {

            this.Balance -= amount;
            return "Withdrawn !";

        }


        public abstract void Transfer(string From, string To, double amount);
       
    }
}
