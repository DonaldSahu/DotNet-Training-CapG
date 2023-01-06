using System;
using System.Collections.Generic;
using System.Text;
using static Assignment6._3.ICICIBank;

namespace Assignment6._3
{

    class Account
    {
        private double accNo, balance;
        private string cusName;

        public double ACCNO { get; set; }
        public double BALANCE { get; set; }
        public string CUSNAME { get; set; }

        public Account() { }

        public Account(double accNo, string cusName, double balance)
        {
            this.ACCNO = accNo;
            this.CUSNAME = cusName;
            this.BALANCE = balance;
        }
       

        public void Deposite(double amount)
        {
            BALANCE += amount;
            Console.WriteLine("Amount Deposited.");
            displayBalance();
        }

        public void Withdrawn(double amount,  eventDelegate balanceZero,eventDelegate underBalance)
        {
            if (!balanceZero(amount) && !underBalance(amount))
            {
                BALANCE -= amount;
                Console.WriteLine("Withdrawn Successful");
                displayBalance();
            }
            
        }
         
        public void displayBalance()
        {
            Console.WriteLine($"Name: {CUSNAME},  Balance: Rs.{BALANCE}");
        }

    }
}
