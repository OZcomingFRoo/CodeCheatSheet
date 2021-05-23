using System;

namespace CShaprtOOPConcepts.Inheritance
{
    // The most basic conpect of all to allow developers not duplicate members e.g. props and methods
    // Instead of showing examples for how "it works", let's test the limit of CSharp's Inheritance capability, limits and rules

    public interface Interface1 { }
    public interface Interface2 { }
    public class ShallowClass { public int MyProperty { get; set; } }
    public class ShallowClass2 { public int MyProperty2 { get; set; } }
    public abstract class AbstractClass { public int AbstractProperty { get; set; } }
    public abstract class AbstractClass2 { public int AbstractProperty2 { get; set; } }

    public class Inherit1Class : ShallowClass { } // Obvious ✅

    // public class Inherit2Classes : ShallowClass , ShallowClass2 { } // Obvious, you can't inherit 2 classes in C# ❌

    public class InheritMultipleInterfaces : Interface1 , Interface2 { } // Obvious ✅

    /// <summary>
    /// C# Want base class 1st and then the interfaces
    /// </summary>
    public class Inherit2Intefaces1Class : ShallowClass , Interface1 , Interface2  { } // Can, but again only 1 class ✅

    public class Inherit1Abstract : AbstractClass { } // Obvious ✅

    // public class Inherit2Classes : AbstractClass, AbstractClass2 { } // Again, you can't inherit 2 classes in C# ❌ doesn't matter if they're abstract
}
