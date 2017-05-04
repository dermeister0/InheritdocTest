namespace InheritdocTest
{
    /// <summary>
    /// Interface for processes that could be stopped.
    /// </summary>
    public interface IStoppable
    {
        /// <summary>
        /// Stops the process.
        /// </summary>
        void Stop();
    }
}
