using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentDbContext();
            var st = new Student
            {
                ID = 3,
                Name = "Doni Sahu",
                Phone = 774256
            };

            var st1 = new Student { ID = 3 };            
            context.Students.Attach(st1);                                      //Delete
            context.Students.Remove(st1);

            //context.Students.Add(st);                                        //insert

            /*context.Students.Attach(st);                                     //update   
            context.Entry(st).Property(p => p.Phone).IsModified = true;*/

            context.SaveChanges();

           /* using (context)                                                  //Retreive
            {
                foreach(var s in context.Students)
                {
                    Console.WriteLine(s.ID+"\n"+s.Name+"\n"+s.Phone);
                }
                Console.ReadKey();
            }*/
        }
    }
}
