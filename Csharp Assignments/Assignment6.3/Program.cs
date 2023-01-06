using System;

namespace Assignment6._3
{

    public delegate bool eventDelegate(double amount);
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ICICIBank icici = new ICICIBank(12345678, "Donald", 5000);
            eventDelegate balanceZero = new eventDelegate(icici.BalanceZero);
            eventDelegate underBalance = new eventDelegate(icici.UnderBalance);
            icici.displayBalance();
            icici.Deposite(2000);
            icici.Withdrawn(1000, balanceZero, underBalance);*/


            HDFCBank hdfc = new HDFCBank(5668342100, "Donald", 5000);
            eventDelegate balanceZero = new eventDelegate(hdfc.BalanceZero);
            eventDelegate underBalance = new eventDelegate(hdfc.UnderBalance);
            hdfc.displayBalance();
            hdfc.Deposite(200);
            hdfc.Withdrawn(100, balanceZero, underBalance); 


            //Account ac = new Account(12345678, "Donald", 0);
            //ac.displayBalance();
            //ac.Deposite(2000);
            //ac.Withdrawn(10000, balanceZero,underBalance);





        }
    }
}
