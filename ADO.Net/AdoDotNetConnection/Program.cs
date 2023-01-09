using System;
using System.Data.SqlClient;
namespace AdoDotNetConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            FunctionClass functionClass = new FunctionClass();
            Console.WriteLine("1.Select\n2.Insert\n3.Delete\n4.Update\n5.Search\n");
            Console.WriteLine("Enter your choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            char c;
            do
            {


                switch (ch)
                {
                    case 1:
                        functionClass.RetrieveData();
                        break;

                    case 2:
                        functionClass.AddData();
                        Console.WriteLine("Data Inserted Successfully");
                        break;

                    case 3:
                        functionClass.DeleteData();
                        Console.WriteLine("Data Deleted Successfully");
                        break;

                    case 4:
                        functionClass.UpdateData();
                        break;

                    case 5:
                        functionClass.SearchData();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue? (y or n)");
                c = Console.ReadLine()[0];
            } while (c != 'n');
        }
    }
}
