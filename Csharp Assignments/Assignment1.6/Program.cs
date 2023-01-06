using System;

namespace Assignment1._6
{
    class Program
    {
        public enum bookType {
            Magazine,
            Novel,
            ReferenceBook, 
            Miscellaneous 
        };
        struct Books
        {
            public int bookId;
            public string title;
            public double price;
            public bookType bookT;
            
            public void Input()
            {
             
                    Console.WriteLine("Enter Book Id : ");
                    bookId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Title : ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter Price : ");
                    price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Book Type: ");
                    Console.WriteLine("1. Magazine");
                    Console.WriteLine("2. Novel");
                    Console.WriteLine("3. Reference Book");
                    Console.WriteLine("4. Miscellaneous");
                    int t = Convert.ToInt32(Console.ReadLine());
                    bookT = (bookType)t;
                
            }

            public void Display()
            {
                    Console.WriteLine("Book Id   :{0} ",bookId);
                    Console.WriteLine("Title     :{0} ",title);
                    Console.WriteLine("Price     :{0} ",price);
                    
                    Console.WriteLine("Book Type :{0} ",bookT);
            }
        };

        static void Main(string[] args)
        {
            Books b = new Books();
            b.Input();
            b.Display();
        }
    }
}
