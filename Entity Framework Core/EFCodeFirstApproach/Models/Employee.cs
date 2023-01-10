using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }
}
