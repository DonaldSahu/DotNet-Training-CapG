using System;
using System.Collections.Generic;
using System.Text;

namespace LitwareLib
{
    [Serializable]
    class Manager:Employee,IPrintable
    {
        private double petrolAllowance, foodAllowance, otherAllowance, mgrossSalary, PF, TDS, netSalary;

        public Manager() { }
        public Manager(int EmpNo, string EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {
            this.PFM = PFM;
            this.TDSM = TDSM;
            this.PETROLALLOWANCE = petrolAllowance;
            this.FOODALLOWANCE = foodAllowance;
            this.OTHERALLOWANCE = otherAllowance;
            this.MGROSSSALARY = mgrossSalary;
        }

        public double PETROLALLOWANCE
        {
            get { return petrolAllowance; }
            set
            {
                petrolAllowance = (SALARY * 8) / 100;
            }
        }
        public double FOODALLOWANCE
        {
            get { return foodAllowance; }
            set
            {
                foodAllowance = (SALARY * 13) / 100;
            }
        }
        public double OTHERALLOWANCE
        {
            get { return otherAllowance; }
            set
            {
                otherAllowance = (SALARY * 3) / 100;
            }
        }
        public double MGROSSSALARY
        {
            get { return mgrossSalary; }
            set
            {
                mgrossSalary = GROSSSALARY + PETROLALLOWANCE + FOODALLOWANCE + OTHERALLOWANCE;
            }
        }

        public double PFM
        {
            get { return PF; }
            set
            {
                PF = (GROSSSALARY * 10) / 100;
            }
        }

        public double TDSM
        {
            get { return TDS; }
            set
            {
                TDS = (GROSSSALARY * 18) / 100;
            }
        }

        public override double CalculateSalary()
        {
            netSalary = GROSSSALARY - (PFM + TDSM);
            return netSalary;
        }

        public new void Display()
        {
            Console.WriteLine("\nManager Details...");
            Console.WriteLine("EmpNo : " + EMPNO);
            Console.WriteLine("EmpName : " + EMPNAME);
            Console.WriteLine("Salary :" + SALARY);
            Console.WriteLine("Gross Salary : " + MGROSSSALARY);
            Console.WriteLine("NetSalary : " + CalculateSalary());

        }
    }
}
