using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    /// <summary>
    /// Model used for HowToUsePages
    /// </summary>
    public class HowToUseModel
    {
        public int Number { get; set; } = 123;
        public decimal DecimalNumber { get; set; } = 1.37m;
        public double AltDecimalNum { get; set; } = 42.11;
        public string Sentence { get; set; } = "This property was init by the Model automatically";
        public bool Boolean { get; set; } = true;
        public char Character { get; set; } = 'C';
        public DateTime DateAndTime { get; set; } = DateTime.Now;
        public short[] NumArr { get; set; } = new short[0];
        public HowToUseProp ObjectProp { get; set; } = new HowToUseProp();
    }
    public class HowToUseProp
    {
        public int Age { get; set; } = 26;
        public string Name { get; set; } = "Ookami";
        public Gender Gender { get; set; } = Gender.Male;

    }
    public enum Gender 
    {
        NA = 0,
        Male = 1,
        Female = 2,
    } 
}
