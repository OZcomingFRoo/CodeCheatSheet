using System;
namespace CShaprtOOPConcepts.Abstract
{
    /// <summary>
    /// Absolutely!<br/>
    /// Notice that the class implaments the abstract method and properties
    /// </summary>
    public abstract class CanAbstractInheritAbstract : ShallowAbstract
    {
        public override int AbstractPropNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string AbstractPropString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        internal override bool AbstractPropBool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AbstractMethodVoid()
        {
            throw new NotImplementedException();
        }

        protected override int AbstractMethodInt()
        {
            throw new NotImplementedException();
        }

        internal override object AbstractMethodObj()
        {
            throw new NotImplementedException();
        }

        public abstract void CanAbstractInheritAbstractMethod();
    }
}
