using Domain;

namespace InheritdocTest
{
    /// <summary>
    /// Simple logger.
    /// </summary>
    public class SimpleLogger : ILogger
    {
        /// <inheritdoc />
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
