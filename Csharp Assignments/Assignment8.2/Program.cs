using System;
using System.Reflection;

namespace Assignment8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type testType = executingAssembly.GetType("Assignment8._2.Test");
            object test = Activator.CreateInstance(testType);
            MethodInfo readMethod = testType.GetMethod("ReadAttributes");

            readMethod.Invoke(test,null);
        }
    }
}
