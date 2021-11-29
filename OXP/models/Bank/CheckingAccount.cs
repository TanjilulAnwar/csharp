using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models
{
    class CheckingAccount:BankAccount
    {
        public double ServiceCharge { get;  set; }
        public CheckingAccount(string accountNo, string customerName, double serviceCharge):base(accountNo,customerName)
        {
            //AccountNo = accountNo;
            //CustomerName = customerName;
            ServiceCharge = serviceCharge;
        }
        public override void Transfer(string From, string To, double amount)
        {

        }
    }
}
