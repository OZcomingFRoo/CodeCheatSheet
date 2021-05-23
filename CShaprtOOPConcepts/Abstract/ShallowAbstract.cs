namespace CShaprtOOPConcepts.Abstract
{
    // Adding the "abstract" keyword, allows you to add abstract methods & properties
    public abstract class ShallowAbstract
    {
        // You can create any Ctor you want, as usual
        public ShallowAbstract(int num, string str, bool bl)
        {
            this.AbstractPropBool = bl;
            this.AbstractPropNum = num;
            AbstractPropString = str;
        }
        public ShallowAbstract() : this(99, "Abstract value string", true)
        {

        }
        internal ShallowAbstract(long _) { }
        protected ShallowAbstract(short _) { }
        private ShallowAbstract(object _) { }


        //public abstract int publicDataMember = 1; // However, You cannot create data-members as abstact
        //internal abstract int internalDataMember = 1; // However, You cannot create data-members as abstact
        //protected abstract int protectedDataMember = 1; // However, You cannot create data-members as abstact
        //private abstract int protectedDataMember = 1; // However, You cannot create data-members as abstact
        public int publicDataMember = 1;
        internal int internalDataMember = 1;
        protected int protectedDataMember = 1;
        private int privateDataMember = 1; 

        public abstract int AbstractPropNum { get; set; }
        internal abstract bool AbstractPropBool { get; set; }
        protected abstract string AbstractPropString { get; set; }
        // private abstract short AbstractPropShort { get; set; } // Cannot set abstract property

        public abstract void AbstractMethodVoid();
        internal abstract object AbstractMethodObj();
        protected abstract int AbstractMethodInt();
        // private abstract bool AbstractMethodBool(); // Cannot set abstract method
        // public abstract long AbstractMethodLong() { } You cannot create an implamented abstract method 

        public long ANormalProp { get; set; }
        public void ANormalMethod() { }
    }
}
