using System;
using System.Collections.Generic;

namespace Assignment5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Team India = new Team();

            Console.WriteLine("Enter no. of Players: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter name of Player: ");
                string nam = Console.ReadLine();

                Console.WriteLine("Enter Runs Scored: ");
                int r = Convert.ToInt32(Console.ReadLine());

                India.AddPlayer(nam,r);
              
                
            }
            India.Display();
            
            //Team t = India.GetEnumerator();
            //Console.WriteLine(t);
            // India.Display();

        }
    }
}
