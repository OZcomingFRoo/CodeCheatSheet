using System;
namespace CShaprtOOPConcepts.Polymorphism
{
    // Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
    // Examples

    #region Example 1 (Inteface Example)
    public interface ICanMakeStake
    {
        void MakeStake();
    }
    public class Person : ICanMakeStake
    {
        public void MakeStake()
        {
            Console.WriteLine("I can make a basic well-done stake");
        }
    }
    public class Chef : ICanMakeStake
    {
        public void MakeStake()
        {
            Console.WriteLine("I can make all types of stakes!");
        }
        public void MakePasta()
        {
            Console.WriteLine("Plus, I can make pasta as well");
        }
    }
    #endregion

    #region Example 2 (Class Example)
    public class Pet
    {
        public string FurColor { get; set; }
        public void Speak()
        {
            Console.WriteLine("making pet sounds");
        }
    }
    public class Cat : Pet
    {
        public new void Speak()
        {
            base.Speak();
            Console.WriteLine("Meow, my fur is " + this.FurColor);
        }
    }
    public class Dog : Pet
    {
        public new void Speak()
        {
            base.Speak();
            Console.WriteLine("Bark, my fur is " + this.FurColor);
        }
    } 
    #endregion


}
