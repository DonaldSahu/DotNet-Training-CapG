using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            List<Account> accountList = new List<Account>();
            int i = 1;
            while (i > 0)
            {

                Console.WriteLine($"Enter details of Customer {i++}");

                Console.WriteLine("ID: ");
                int an = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Balance: ");
                double bal = Convert.ToDouble(Console.ReadLine());

                accountList.Add(new Account(an, name, bal));

                Console.WriteLine("Press U to Update exit or C to add more Customer...");
                char ch = Console.ReadLine()[0];
                if (ch == 'E')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }


            string path = @"C:\FileHanding Files\Assignment7.2\Account Details";

            using (StreamWriter writer = new StreamWriter(path))
            {
               
                foreach(var item in accountList)
                {
                    writer.WriteLine($"Name: {item.CUSNAME}\nAccount Number: {item.ACCNO}\nBalance: {item.BALANCE}\n");
                }
                Console.WriteLine("Account Details Updated...");
            }

            Console.WriteLine("\nDetails of all the Account Holders: ");
            using(StreamReader reader =new StreamReader(path))
            {
                string accountDetails = reader.ReadToEnd();
                Console.WriteLine(accountDetails);
            }
        }
    }
}
