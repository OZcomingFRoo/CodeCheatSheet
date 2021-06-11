namespace CShaprtOOPConcepts.Interface
{
    /// <summary>
    /// Yup! Notice that he can have his own method and properties <br/>
    /// and not implament any others from the interface he inherited
    /// </summary>
    public interface CanInterfaceInheritInterface : ShallowInterface
    {
        int Property { get; set; }
        public void Method();
    }
}
