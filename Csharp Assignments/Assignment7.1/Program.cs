using System;
using System.IO;

namespace Assignment7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\FileHanding Files\File1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File Not Found!!");
            }

            
            string path2 = @"C:\FileHanding Files\New Files";
            DirectoryInfo dir = new DirectoryInfo(path2);
            DirectoryInfo[] dirs = dir.GetDirectories();
            Console.WriteLine("\nSubDirectories: ");
            foreach (var item in dirs)
            {
                Console.WriteLine(item.Name);
            }
            
            
        }
    }
}
