using LitwareLib;
using System;

namespace EmployeeManagement
{
    class Program
    {
        public delegate void EmployeeDelegate();
        static void Main(string[] args)
        {
            //Employee e = new Employee(2,"Donald22",50000);
            //e.Display();

            Manager manager = new Manager(1, "Donald", 50000);
            //emp.Display();

            MarketingExecutive me = new MarketingExecutive(3, "Donu", 50000);
            //me.Display();

            EmployeeDelegate ed = new EmployeeDelegate(manager.Display);
            ed += me.Display;
            ed();

        }
    }
}
