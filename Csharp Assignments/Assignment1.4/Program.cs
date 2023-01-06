using System;

namespace Assignment1._4
{
    class Program
    {
        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a=" +a);
            Console.WriteLine("b="+b);
        }
        static void Main(string[] args)
        {
            swap(34, 59);
        }
    }
}
