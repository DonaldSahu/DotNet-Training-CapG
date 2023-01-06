using System;

namespace Assignment1._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("Enter Marks: ");
            int high = 0;
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (high < arr[i])
                {
                    high = arr[i];
                }
            }
            Console.WriteLine(high);
        }
    }
}
