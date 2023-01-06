using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._1
{
    [Serializable]
    class Employee
    {
        private int EmpNo { get; set; }
        private string EmpName;
        private double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

        public Employee(int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
            this.GROSSSALARY = GROSSSALARY;

        }

        public Employee() { }

        public int EMPNO
        {
            get { return EmpNo; }
            set
            {
                this.EmpNo = value;
            }
        }

        public string EMPNAME
        {
            set { this.EmpName = value; }
            get { return EmpName; }
        }
        public double SALARY
        {
            get { return Salary; }
            set { this.Salary = value; }
        }
        public double GROSSSALARY
        {
            get { return GrossSalary; }
            set {
                if (Salary < 5000)
                {
                    HRA = 0.1 * Salary;
                    TA = 0.05 * Salary;
                    DA = 0.15 * Salary;
                }
                else if (Salary < 10000)
                {
                    HRA = 0.15 * Salary;
                    TA = 0.1 * Salary;
                    DA = 0.5 * Salary;
                }
                else if (Salary < 15000)
                {
                    HRA = 0 / .2 * Salary;
                    TA = 0.15 * Salary;
                    DA = 0.4 * Salary;
                }
                else if (Salary < 20000)
                {
                    HRA = 0.4 * Salary;
                    TA = 0.5 * Salary;
                    DA = 0.3 * Salary;
                }
                else if (Salary >= 20000)
                {
                    HRA = 0.3 * Salary;
                    TA = 0.4 * Salary;
                    DA = 0.35 * Salary;
                }

                GrossSalary = Salary + HRA + TA + DA;
            }
        }


        public double pf
        {
            get { return PF; }
            set
            {
                this.PF = (GROSSSALARY * 0.1);
            }
        }

        public double tds
        {
            get { return TDS; }
            set
            {
                this.TDS = (GROSSSALARY * 18) / 100;
            }
        }

        public virtual double CalculateSalary()
        {
            NetSalary = GrossSalary - (PF + TDS);
            return NetSalary;
        }

        public void Display()
        {
            Console.WriteLine("\nEmployee Details...");
            Console.WriteLine("EmpNo : "+EmpNo);
            Console.WriteLine("EmpName : "+EmpName);
            Console.WriteLine("Salary :"+Salary);
            Console.WriteLine("Gross Salary : "+GrossSalary);
            Console.WriteLine("NetSalary : "+CalculateSalary());

        }

        
    }
}
