using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5._2
{
    class Employee
    {
        private int eId;
        private string eName;
        private double Salary;

        public int EID
        {
            get { return eId; }
            set
            {
                eId = value;
            }
        }
        public string ENAME
        {
            get { return eName; }
            set
            {
                eName = value;
            }
        }
        public double SALARY
        {
            get { return Salary; }
            set
            {
                Salary = value;
            }
        }

        public Employee(int eId, string eName,double Salary)
        {
            EID = eId;
            ENAME = eName;
            SALARY = Salary;
        }

        public override string ToString()
        {
            return "Id: " + EID + "\nName: " + ENAME + "\nSalary: " + SALARY;
        }
    }
}
