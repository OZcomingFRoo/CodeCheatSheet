using System;

namespace CShaprtOOPConcepts.Interface
{
    
    public interface ShallowInterface 
    {
        // object dataMember; // Obviously you can't create data-members

        int InterfaceProp { get; set; }
        int InterfaceVoidMethod();
        

        public long PublicProp { get; set; }
        internal long InternalProp { get; set; }
        protected long ProtectedProp { get; set; }
        // private long PrivateProp { get; set; } // you can't make privates of course

        public void PublicMethod();
        internal void InternalMethod();
        protected void ProtectedVoidMethod();
        // private long PrivateVoidMethod(); // you can't make privates of course
    }
    /// <summary>
    /// You can also make an internal DLL inteface
    /// </summary>
    internal interface InternalShallowInterface { }
}
