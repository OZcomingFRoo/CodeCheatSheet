using System;
using System.Collections.Generic;
using System.Text;

namespace CShaprtOOPConcepts.Abstract
{
    public abstract class InheritMultiAbstractClasses___AbstractClass1 { }
    public abstract class InheritMultiAbstractClasses___AbstractClass2 { }

    /// <summary>
    /// Can you make a class inherit mutliple abstract class? <br/>
    /// The answer is no, unlike interface, <b>abstract class</b> is still a class<br/>
    /// and since C# doesn't allow mutliple class inheritence, unlike in TS and C++, you cannot perform such desire on abstract as well
    /// </summary>
    public class InheritMultiAbstractClasses___Class 
        // : InheritMultiAbstractClasses___AbstractClass1 , InheritMultiAbstractClasses___AbstractClass2 Throws an error
    {
    }
}
