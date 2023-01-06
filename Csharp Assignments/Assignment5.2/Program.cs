using System;
using System.Collections;

namespace Assignment5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList empList = new ArrayList();

            Console.WriteLine("Enter no. of Employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details of employee {i + 1}");

                Console.WriteLine("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double sal = Convert.ToDouble(Console.ReadLine());

                empList.Add(new Employee(id,name,sal));
            }

            Console.WriteLine("Displaying Employee Details: ");
            foreach(object o in empList)
            {
                Console.WriteLine(o + "\n");
            }


        }
    }
}
