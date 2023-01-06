using System;

namespace Assignment1._3
{
    class Program
    {
        public static void paramArray(params int[] arr)
        {
            int s = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                s+=arr[i];
            }
            Console.WriteLine("sum = "+ s);
        }
        static void Main(string[] args)
        {
            paramArray(3,4,1,2,5,15);
        }
    }
}
