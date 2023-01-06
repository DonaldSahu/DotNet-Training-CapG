using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7._4
{
    [Serializable]
    class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Manager(int Id,string Name,int Salary) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }
    }
}
