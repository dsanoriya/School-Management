using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public class Studenttype
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int ID { get; set; }
        public Enums.Grade grade { get; set; }
    }
}
