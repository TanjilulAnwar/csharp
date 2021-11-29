using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models
{
    class SavingAccount:BankAccount
    {
        public double InterestAmount { get; set; }

        public SavingAccount(string accountNo, string customerName,double interestAmount):base(accountNo,customerName)
        {
            //AccountNo = accountNo;
            //CustomerName = customerName;
            InterestAmount = interestAmount;
        }




        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                //Balance -= amount;
                //return "Withdrawn !";
               
                return base.Withdraw(amount);//base method needs to be called so the method does not become recursive
            }

            return "Insufficient Balance !";
        }
         public override void Transfer(string From, string To, double amount)
        {

        }


    }
}
