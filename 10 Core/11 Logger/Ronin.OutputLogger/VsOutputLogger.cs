using System;
using System.Diagnostics;
using Ronin.LoggerContract;
using Ronin.LoggerContract.Extensibility.Exports;

namespace Ronin.OutputLogger
{
    [LoggerExport(typeof(ILogger))]
    internal class VsOutputLogger : ILogger
    {
        /// <summary>
        /// Log exception with a option to give an additional message
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        public void Log(Exception ex, string message = null)
        {
            Trace.WriteLine(DateTime.Now);
            Trace.WriteLine(ex);
            Trace.WriteLine(message);
        }

        /// <summary>
        /// Log an exception together with fault data if any with option of serialization and extra message
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <param name="instance"></param>
        /// <param name="message"></param>
        public void Log<T>(Exception ex, T instance, string message = null) where T : class
        {
            var _instanceDescription = (instance != null ? instance.ToString() : typeof(T) + " " + "IsNull");
            var _logMessage = !string.IsNullOrEmpty(message)
                                  ? string.Format(@"{0}{1}{2}", message, Environment.NewLine, _instanceDescription)
                                  : _instanceDescription;

            Trace.WriteLine(DateTime.Now);
            Trace.WriteLine(ex);
            Trace.WriteLine(_logMessage);
        }

        /// <summary>
        /// Log an message
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Trace.WriteLine(DateTime.Now);
            Trace.WriteLine(message);
        }

        /// <summary>
        /// Log an instance with an option of serialization
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        public void Log<T>(T instance) where T : class
        {
            var _instanceDescription = (instance != null ? instance.ToString() : typeof(T) + " " + "IsNull");
            Log(_instanceDescription);
        }

        /// <summary>
        /// Logs an exception
        /// </summary>
        /// <param name="ex"></param>
        public void Log(Exception ex)
        {
            Trace.WriteLine(DateTime.Now);
            Trace.WriteLine(ex);
        }
    }
}
