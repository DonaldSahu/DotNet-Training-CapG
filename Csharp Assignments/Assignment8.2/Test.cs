using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment8._2
{
    class Test
    {
        public void ReadAttributes()
        {
            Attribute[] attribute1 = Attribute.GetCustomAttributes(typeof(HDFCAccount));
            Attribute[] attribute2 = Attribute.GetCustomAttributes(typeof(HDFCAccount));

            Console.WriteLine("----------------HDFC Account Attributes----------------");
            foreach(Attribute atr in attribute1)
            {
                Console.WriteLine($"ATTRIBUTE APPLIED ON THIS CLASS : {atr}");
                Type t = atr.GetType();
                MethodInfo[] methods = t.GetMethods();
                PropertyInfo[] properties = t.GetProperties();

                Console.WriteLine("-----Methods Info-----");
                foreach(MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                }

                Console.WriteLine("-----Properties Info-----");
                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }

            }


            Console.WriteLine("----------------ICICI Account Attributes----------------");
            foreach (Attribute atr in attribute1)
            {
                Console.WriteLine($"ATTRIBUTE APPLIED ON THIS CLASS : {atr}");
                Type t = atr.GetType();
                MethodInfo[] methods = t.GetMethods();
                PropertyInfo[] properties = t.GetProperties();

                Console.WriteLine("-----Methods Info-----");
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                }

                Console.WriteLine("-----Properties Info-----");
                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }

            }
        }
    }
}
