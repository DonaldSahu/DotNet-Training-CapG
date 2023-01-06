using System;

namespace Assignmemt1._5
{
    class Program
    {
        public static (double, double) circle(double r)
        {
            double area = 3.14 * r * r;
            double circum = 2 * 3.14 * r;

            return (area,Math.Round(circum,2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Area and Circumference are : "+circle(5)+" respectively.");
        }
    }
}
