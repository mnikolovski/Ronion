using System;

namespace Ronin.LoggerContract
{
    /// <summary>
    /// Logger contract
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log exception with a option to give an additional message
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        void Log(Exception ex, string message = null);

        /// <summary>
        /// Log an exception together with fault data if any with option of serialization and extra message
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <param name="instance"></param>
        /// <param name="message"></param>
        void Log<T>(Exception ex, T instance, string message = null) where T : class;

        /// <summary>
        /// Log an message
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);

        /// <summary>
        /// Log an instance with an option of serialization
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        void Log<T>(T instance) where T : class;

        /// <summary>
        /// Log an exception
        /// </summary>
        /// <param name="ex"></param>
        void Log(Exception ex);
    }
}
