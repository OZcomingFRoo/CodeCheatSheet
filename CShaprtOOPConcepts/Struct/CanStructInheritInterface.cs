using System;

namespace CShaprtOOPConcepts.Struct
{
    interface IAmSomeStructInteface { void StructInterfaceMethod(); }
    interface IAmAnotherSomeStructInteface { void AnthoerStructInterfaceMethod(); }
    /// <summary>
    /// Can a struct type inherit an interface?<br/>
    /// Yes it can! and obviosuly can inherit multiple
    /// </summary>
    struct CanStructInheritInterface : IAmSomeStructInteface, IAmAnotherSomeStructInteface
    {
        public void StructInterfaceMethod()
        {
            Console.WriteLine("Yup, you absolutely can");
        }
        public void AnthoerStructInterfaceMethod()
        {
            throw new NotImplementedException();
        }
    }
}
