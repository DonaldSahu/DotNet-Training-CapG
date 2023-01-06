using System;

namespace Assignment3._2
{
    class StackException:Exception
    {
        public StackException(string msg) : base(msg) { }
    }

    class MyStack:ICloneable
    {
        public int[] stack = new int[20];
        public int top = -1;
        public int size;

        public object Clone()
        {
            Console.WriteLine("Cloned Array: ");
            MyStack newStack = new MyStack()
            {
                stack = this.stack,
                top = this.top,
                size = this.size
            };
            return newStack;
        }

        public void push(int item)
        {
            try
            {
                if(top == stack.Length-1)
                {
                    throw new StackException("Stack OverFlow Exception...");
                }
                stack[++top] = item;


            }
            catch(StackException se)
            {
                Console.WriteLine(se);
            }

        }

        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("Stack Underflow...");
                    
                }
                Console.WriteLine("Poped Element is : " + stack[top]);
                top -= 1;
            }
            catch(StackException se)
            {
                Console.WriteLine(se);
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + stack[i]);
                }
            }
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {
            MyStack ms = new MyStack();
            int n;
            do
            {
                Console.WriteLine("Enter choice: ");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Clone");
                Console.WriteLine("5. Exit");

                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter value: ");
                        ms.push(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        ms.pop();
                        break;
                    case 3:
                        ms.printStack();
                        break;
                    case 4:
                        MyStack newStack = ms.Clone() as MyStack;
                        ms.printStack();
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
