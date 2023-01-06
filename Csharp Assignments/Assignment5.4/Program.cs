using System;
using System.Collections.Generic;

namespace Assignment5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n;
            do
            {
                Console.WriteLine("Enter choice: ");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Peek");
                Console.WriteLine("5. Exit");

                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter value: ");
                        int item = Convert.ToInt32(Console.ReadLine());
                        stack.Push(item);
                        break;
                    case 2:
                        Console.WriteLine("Poped Element: "+ stack.Pop());
                        break;
                    case 3:
                        foreach (var i in stack)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 4:
                        Console.WriteLine(stack.Peek());
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            } while (n != 5);
        }
    }
}
