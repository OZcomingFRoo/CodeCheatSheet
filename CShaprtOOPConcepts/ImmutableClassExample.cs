namespace CShaprtOOPConcepts
{
    /// <summary>
    /// This class exibits the examples of an Immutable class<br/>
    /// Sources : <br/>
    /// - https://www.c-sharpcorner.com/article/mutable-and-immutable-class-in-c-sharp/ <br/>
    /// - https://www.codeproject.com/Articles/1043301/Immutable-objects-in-Csharp <br/>
    /// </summary>
    class ImmutableClassExample
    {
        /// <summary>
        /// Make the variables <b>read-only</b> so we can not modify the variable after assigning the first time. 
        /// </summary>
        private readonly string myStr;

        /// <summary>
        /// Use <b>parameterized</b> c-tor for assigning the values of the class while creating the object of the class.
        /// </summary>
        /// <param name="str">Must provide in a Immutable object as the values that were set <b>cannot be changed</b></param>
        public ImmutableClassExample(string str)
        {
            myStr = str;
        }

        /// <summary>
        /// Use properties for getting the variables of the class and remove the setters of the property.<br/>
        /// Inshort, use only getters. 
        /// </summary>
        public string GetStr
        {
            get { return myStr; }
        }
    }
}
