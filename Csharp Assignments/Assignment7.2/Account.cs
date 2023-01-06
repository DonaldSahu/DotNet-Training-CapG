using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7._2
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
    }
}
