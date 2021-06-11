using System;

namespace CShaprtOOPConcepts.Abstract
{
    /// <summary>
    /// Can Abstract Inherit Abstract That Inherit Abstract? <br/>
    /// Yes! he only needs to implament that class's abstract methods & properties
    /// </summary>
    public abstract class CanAbstractInheritAbstractThatInheritAbstract : CanAbstractInheritAbstract
    {
        public override void CanAbstractInheritAbstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
