using System;

namespace InheritdocTest
{
    /// <summary>
    /// Inherited process.
    /// </summary>
    public class InheritedProcess : BaseProcess, IStoppable, IPausable
    {
        /// <inheritdoc />
        public void Pause()
        {
            Console.WriteLine("PAUSE");
        }

        /// <inheritdoc />
        public void Stop()
        {
            Console.WriteLine("STOP");
        }
    }
}
