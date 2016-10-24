// <copyright file="Helpers.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace Jmw.VarChecker
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Helpers functions
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Creates a new Exception
        /// </summary>
        /// <typeparam name="T">Exception type to create.</typeparam>
        /// <param name="message">Exception message</param>
        /// <returns>Created exception</returns>
        public static T CreateException<T>(string message)
            where T : Exception, new()
        {
            if (!string.IsNullOrEmpty(message))
            {
                return (T)Activator.CreateInstance(typeof(T), message);
            }

            return Activator.CreateInstance<T>();
        }
    }
}
