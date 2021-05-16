using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.POCOs
{
    public class SomeObject
    {
        public string Str { get; set; }
        public int Integer { get; set; }
        public char Character { get; set; }
        public bool Boolean { get; set; }
        public bool [] CheckList { get; set; }
        public SomeSubObject SubObjectProperty { get; set; }
    }
}
