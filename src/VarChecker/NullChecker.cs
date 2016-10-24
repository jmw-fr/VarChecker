// <copyright file="NullChecker.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace Jmw.VarChecker
{
    using System;

    /// <summary>
    /// Checks for NULL
    /// </summary>
    public static class NullChecker
    {
        /// <summary>
        /// Checks that the variable is not null.
        /// </summary>
        /// <typeparam name="T">Variable type</typeparam>
        /// <param name="var">Variable to check</param>
        /// <param name="message">Exception message</param>
        /// <returns>The input variable</returns>
        /// <exception cref="ArgumentNullException">If var is null.</exception>
        public static T CannotBeNotNull<T>(this T var, string message = null)
            where T : class
        {
            return var.CannotBeNotNull<ArgumentNullException, T>(message);
        }

        /// <summary>
        /// Checks that the variable is not null.
        /// </summary>
        /// <typeparam name="E">Exception to throw</typeparam>
        /// <typeparam name="T">Variable type</typeparam>
        /// <param name="var">Variable to check</param>
        /// <param name="message">Exception message</param>
        /// <returns>The input variable</returns>
        public static T CannotBeNotNull<E, T>(this T var, string message = null)
            where E : Exception, new()
            where T : class
        {
            if (var == null)
            {
                throw Helpers.CreateException<E>(message);
            }

            return var;
        }
    }
}