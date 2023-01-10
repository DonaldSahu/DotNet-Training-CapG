using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DBFirstDatabaseEntities();
            var emp = new Employee
            {
                EmpID = 8,
                EmpName = "Ruchi Takane",
                EmpSalary = 42000
            };
            context.Employees.Add(emp);
            context.SaveChanges();

            using (context)
            {
                foreach (var s in context.Employees)
                {
                    Console.WriteLine(s.EmpID + "\n" + s.EmpName + "\n" + s.EmpSalary);
                }
                Console.ReadKey();
            }
        }
    }
}
