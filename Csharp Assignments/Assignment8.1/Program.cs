using System;
using System.Reflection;

namespace Assignment8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type addType = executingAssembly.GetType("Assignment8._1.Addition");
            object addition = Activator.CreateInstance(addType);
            MethodInfo findSunmMethod = addType.GetMethod("findSum");

            string[] parameters = new string[2];
            parameters[0] = "6";
            parameters[1] = "4";

            string sum = (string)findSunmMethod.Invoke(addition,parameters);
            Console.WriteLine("Sum: "+ sum);
        }
    }
}
