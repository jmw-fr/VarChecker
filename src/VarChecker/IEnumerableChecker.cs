// <copyright file="IEnumerableChecker.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace Jmw.VarChecker
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Checkers for <see cref="IEnumerable{T}"/>
    /// </summary>
    public static class IEnumerableChecker
    {
        /// <summary>
        /// Checks that the enumerable has elements.
        /// </summary>
        /// <typeparam name="T">Variable type</typeparam>
        /// <param name="var">Variable to check</param>
        /// <param name="message">Exception message</param>
        /// <returns>The input variable</returns>
        /// <exception cref="ArgumentException">If var has no elements</exception>
        public static T MustHaveElements<T>(this T var, string message = null)
            where T : IEnumerable
        {
            if (var != null)
            {
                IEnumerator enumerator = var.GetEnumerator();

                if (!enumerator.MoveNext() || enumerator.Current == null)
                {
                    throw Helpers.CreateException<ArgumentException>(message);
                }
            }

            return var;
        }

        /// <summary>
        /// Checks that the enumerable is empty.
        /// </summary>
        /// <typeparam name="T">Variable type</typeparam>
        /// <param name="var">Variable to check</param>
        /// <param name="message">Exception message</param>
        /// <returns>The input variable</returns>
        /// <exception cref="ArgumentException">If var has elements</exception>
        public static T MustBeEmpty<T>(this T var, string message = null)
        where T : IEnumerable
        {
            if (var != null)
            {
                IEnumerator enumerator = var.GetEnumerator();

                if (enumerator.MoveNext() && enumerator.Current != null)
                {
                    throw Helpers.CreateException<ArgumentException>(message);
                }
            }

            return var;
        }
    }
}
