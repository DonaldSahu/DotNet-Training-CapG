using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6._3
{
    
    class ICICIBank:Account
    {
        public ICICIBank() { }
        public ICICIBank(double accNo, string cusName, double balance) :base(accNo, cusName, balance)
        {
            
        }
        
        public bool BalanceZero(double amount)
        {
            if (BALANCE <= 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is zero in Account!!!");
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool UnderBalance(double amount)
        {
            if (BALANCE < amount)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient in Account!!!");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
