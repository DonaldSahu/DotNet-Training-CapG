using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8._1
{
    class Addition
    {
        public string findSum(string a,string b)
        {
            int s = int.Parse(a) + int.Parse(b);
            return s.ToString();
        }
    }
}
