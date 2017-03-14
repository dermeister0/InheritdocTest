using System;

namespace InheritdocTest
{
    /// <summary>
    /// Basic implementation of ITest.
    /// </summary>
    public class Test : ITest
    {
        /// <inheritdoc />
        public void WriteMoo()
        {
            Console.WriteLine("Moo");
        }
    }
}
