using System;

namespace InheritdocTest
{
    /// <summary>
    /// Inherited process.
    /// </summary>
    public class InheritedProcess : BaseProcess, IStoppable
    {
        /// <inheritdoc />
        public void Stop()
        {
            Console.WriteLine("STOP");
        }
    }
}
