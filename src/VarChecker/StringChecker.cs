// <copyright file="StringChecker.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace Jmw.VarChecker
{
    using System;

    /// <summary>
    /// Cheker for <see cref="string" />
    /// </summary>
    public static class StringChecker
    {
        /// <summary>
        /// Checks that the string is not null or empty
        /// </summary>
        /// <param name="var">Variable to check</param>
        /// <param name="message">Exception message</param>
        /// <returns>The input variable</returns>
        public static string CannotNotNullOrEmpty(this string var, string message = null)
        {
            return var.CannotNotNullOrEmpty<ArgumentException>(message);
        }

        /// <summary>
        /// Checks that the string is not null or empty
        /// </summary>
        /// <typeparam name="TException">Exception to throw</typeparam>
        /// <param name="var">Variable to check</param>
        /// <param name="message">Exception message</param>
        /// <returns>The input variable</returns>
        public static string CannotNotNullOrEmpty<TException>(this string var, string message = null)
            where TException : Exception, new()
        {
            if (string.IsNullOrEmpty(var))
            {
                throw Helpers.CreateException<TException>(message);
            }

            return var;
        }
    }
}
