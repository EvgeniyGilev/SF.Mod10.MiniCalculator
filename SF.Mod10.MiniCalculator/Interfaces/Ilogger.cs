namespace SF.Mod10.MiniCalculator.Interfaces
{
    /// <summary>
    /// The logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Events the.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="severity">The severity.</param>
        public void Event(string message, int severity);
    }
}
