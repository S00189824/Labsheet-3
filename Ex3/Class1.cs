using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class BankAccount
    {
        public string accountNumber { get; set; }//properties

        public string accountHolder { get; set; }//properties

        public double balance { get; set; }//properties

        public BankAccount(string AccountNumber,string AccountHolder,double Balance)
        {
            //A constructor which takes all properties as parameters.
            accountNumber = AccountNumber;

            accountHolder = AccountHolder;

            balance = Balance;
        }
    }
}
