// ================================================================================ //
// This is used to demonstrate how the ViewImports work when using namespaces to give 
// In
// ================================================================================ //


namespace SomeRootViewImportObject
{
    /// <summary>
    /// This object can be called directly without writing the namespace.
    /// This is available for all Views
    /// </summary>
    public class ObscureRootObj
    {
    }
}
namespace SomeRootHomeViewImportObject
{
    /// <summary>
    /// This object can be called directly without writing the namespace.
    /// This is only present for the Home Ctrl-Views
    /// </summary>
    public class ObscureHomeObj
    {
    }
}
