using firstmvcapp.shared.enums;
using System;

namespace firstmvcapp.Models
{
    public class personmodel
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public genderenum Genderlabel { get; set; }
        public String gender => Genderlabel.ToString(); 
        public int Age { get; set; }
        public String Major { get; set; } 
    }
}