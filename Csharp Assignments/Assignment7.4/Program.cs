using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment7._4
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\FileHanding Files\Assignment7.4\ManagerObject.txt";
            Manager manager = new Manager(101, "Donald", 50000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, manager);
            //stream.Close();
            //Console.WriteLine("File Created Successfully => " + path);

            Manager manager1 = (Manager)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine($"Employee ID: {manager1.Id} \nEmployee Name: {manager1.Name} " +
                              $"\nEmployee Salary: {manager1.Salary}\n");

        }
    }
}
