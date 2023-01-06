using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8._2
{
    class SoftwareAttribute:Attribute
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }
        public string StartedDate { get; set; }
        public string EndDate { get; set; }

    }
}
