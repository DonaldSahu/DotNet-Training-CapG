using System;
using System.Collections.Generic;
using System.Text;

namespace LitwareLib
{
    [Serializable]
    class MarketingExecutive:Employee,IPrintable
    {
        private double km, tourAllowance, telephoneAllowance, megrossSalary, PF, TDS, menetSalary;

        public double KM { get; set; }
        public double TOURALLOWANCE
        {
            get { return tourAllowance; }
            set
            {
                tourAllowance = 5 * KM;
            }
        }

        public double TELEPHONEALLOWANCE
        {
            get { return telephoneAllowance; }
            set
            {
                telephoneAllowance = 1000;
            }
        }

        public double PFME
        {
            get { return PF; }
            set
            {
                PF = (GROSSSALARY * 10) / 100;
            }
        }

        public double TDSME
        {
            get { return TDS; }
            set
            {
                TDS = (GROSSSALARY * 18) / 100;
            }
        }

        public double MEGROSSSALARY
        {
            get { return megrossSalary; }
            set
            {
                megrossSalary = GROSSSALARY + TOURALLOWANCE + TELEPHONEALLOWANCE;
            }
        }

        public override double CalculateSalary()
        {
            menetSalary = GROSSSALARY - (PFME + TDSME);
            return menetSalary;
        }

        public MarketingExecutive() { }

        public MarketingExecutive(int EmpNo, string EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {
            this.PFME = PF;
            this.TDSME = TDS;
            this.TOURALLOWANCE = tourAllowance;
            this.TELEPHONEALLOWANCE = telephoneAllowance;
            this.MEGROSSSALARY = megrossSalary;
        }

        public new void Display()
        {
            Console.WriteLine("\nMrketing Executive Details...");
            Console.WriteLine("EmpNo : " + EMPNO);
            Console.WriteLine("EmpName : " + EMPNAME);
            Console.WriteLine("Salary :" + SALARY);
            Console.WriteLine("Gross Salary : " + MEGROSSSALARY);
            Console.WriteLine("NetSalary : " + CalculateSalary());

        }
    }
}
