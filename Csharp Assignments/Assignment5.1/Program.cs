using System;

namespace Assignment5._1
{
    class Program
    {

        public static void display(string[] A)
        {
            foreach(string i in A)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            /*
            int[] arrInt = new int[size];
            int[] arrInt2 = new int[size];
            Console.WriteLine("Enter Elements: ");
            for(int i = 0; i < size; i++)
            {
                arrInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            display(arrInt);

            Console.WriteLine("Copied Array: ");
            Array.Copy(arrInt, arrInt2,size);
            display(arrInt2);

            Console.WriteLine("Sorted Array: ");
            Array.Sort(arrInt);
            display(arrInt);

            Console.WriteLine("Reversed Array: ");
            Array.Reverse(arrInt);
            display(arrInt);

            Console.WriteLine("Cleared Array: ");
            Array.Clear(arrInt,0,size);
            display(arrInt);
            */



            string[] arrStr = new string[size];
            string[] arrStr1 = new string[size];
            Console.WriteLine("Enter Elements: ");
            for (int i = 0; i < size; i++)
            {
                arrStr[i] = Console.ReadLine();
            }

            display(arrStr);

            Console.WriteLine("Copied Array: ");
            Array.Copy(arrStr, arrStr1, size);
            display(arrStr1);

            Console.WriteLine("Sorted Array: ");
            Array.Sort(arrStr);
            display(arrStr);

            Console.WriteLine("Reversed Array: ");
            Array.Reverse(arrStr);
            display(arrStr);

            Console.WriteLine("Cleared Array: ");
            Array.Clear(arrStr, 0, size);
            display(arrStr);

        }
    }
}
