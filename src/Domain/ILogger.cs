namespace Domain
{
    /// <summary>
    /// Contains methods for logging.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Saves message to log.
        /// </summary>
        /// <param name="message">The message.</param>
        void Log(string message);
    }
}
