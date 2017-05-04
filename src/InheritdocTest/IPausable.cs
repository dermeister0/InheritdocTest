namespace InheritdocTest
{
    /// <summary>
    /// Interface for processes that could be paused.
    /// </summary>
    internal interface IPausable
    {
        /// <summary>
        /// Pauses the process.
        /// </summary>
        void Pause();
    }
}
