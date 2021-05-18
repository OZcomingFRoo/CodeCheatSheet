using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    /// <summary>
    /// Model used for HowToUsePages
    /// </summary>
    public class HowToUseModel
    {
        [Display(Name = "מספר שלם")]
        public int Number { get; set; } = 123;
        public decimal DecimalNumber { get; set; } = 1.37m;
        public double AltDecimalNum { get; set; } = 42.11;
        [Display(Name = "מחרוזת")]
        public string Sentence { get; set; } = "This property was init by the Model automatically";
        public bool Boolean { get; set; } = true;
        public char Character { get; set; } = 'C';
        public DateTime DateAndTime { get; set; } = DateTime.Now;
        public char[] NumArr { get; set; } = "Character Array".ToCharArray();
        public HowToUseProp ObjectProp { get; set; } = new HowToUseProp();
    }
    public class HowToUseProp
    {
        public int Age { get; set; } = 26;
        public string Name { get; set; } = "Kunimitsu";
        public Gender Gender { get; set; } = Gender.Female;

    }
    public enum Gender
    {
        NA = 0,
        Male = 1,
        Female = 2,
    }
}
