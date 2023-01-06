using System;

namespace Assignment1._1
{
    public class Calc
    {
        public static void Main(string[] args)
        {
            int val1, val2;
            Console.WriteLine("Enter values: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            val2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = val1 + val2;
            Console.WriteLine("Addition : " + sum1);
            int sub = val1 - val2;
            Console.WriteLine("Subtraction : " + sub);
            Console.WriteLine("Multiplication : " + val1 * val2);
            Console.WriteLine("Division : " + val1 / val2);
        }
    }
}
