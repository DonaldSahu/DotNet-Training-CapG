using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<object> empList = new LinkedList<object>();

            //Console.WriteLine("Enter no. of Employees: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while(i>0)
            {    
                
                Console.WriteLine($"Enter details of employee {i++}");

                Console.WriteLine("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double sal = Convert.ToDouble(Console.ReadLine());

                empList.AddLast(new Employee(id, name, sal));

                Console.WriteLine("Press E exit or C to continue...");
                char ch = Console.ReadLine()[0];
                if (ch == 'E')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\nDo you want to search an Employee? or Want to display all the Employees? " +
                                                                   " (Press S for Search and D to Display)");
            char ch1 = Console.ReadLine()[0];
            if (ch1 == 'S')
            {
                Console.WriteLine("Enter name of an Employee: ");
                string nam = Console.ReadLine();

                foreach(Employee ob in empList)
                {
                    if(ob.ENAME == nam)
                    {
                        Console.WriteLine("\n" + ob);
                        System.Environment.Exit(0);
                    }
                }
                

                //object e = empList.Find(nam);
                //Console.WriteLine(e);
                
            }
            else
            {
                Console.WriteLine("\nDisplaying Employee Details: ");
                foreach (object o in empList)
                {
                    Console.WriteLine(o + "\n");
                }

                Console.WriteLine("\nTotal No. of employees: " + empList.Count);
            }
        }
    }
}
