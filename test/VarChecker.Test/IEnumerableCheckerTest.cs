// <copyright file="IEnumerableCheckerTest.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace VarChecker.Test
{
    using System;
    using System.Collections.Generic;
    using FluentAssertions;
    using Jmw.VarChecker;
    using Xunit;

    /// <summary>
    /// Test class of <see cref="IEnumerableChecker"/>.
    /// </summary>
    public class IEnumerableCheckerTest
    {
        /// <summary>
        /// Test of <see cref="IEnumerableChecker.MustBeEmpty{T}(T, string)" />
        /// </summary>
        [Fact]
        public void CheckMustBeEmpty()
        {
            object[] arrayEmpty = { };
            List<object> listEmpty = new List<object>();
            object[] arrayNotEmpty = { new object() };
            List<object> listNotEmpty = new List<object>(arrayNotEmpty);

            Action act1 = () => arrayEmpty.MustBeEmpty();
            Action act2 = () => listEmpty.MustBeEmpty();
            Action act3 = () => arrayNotEmpty.MustBeEmpty();
            Action act4 = () => listNotEmpty.MustBeEmpty();

            act1.ShouldNotThrow();
            act2.ShouldNotThrow();
            act3.ShouldThrow<ArgumentException>();
            act4.ShouldThrow<ArgumentException>();
        }

        /// <summary>
        /// Test of <see cref="IEnumerableChecker.MustHaveElements{T}(T, string)" />
        /// </summary>
        [Fact]
        public void CheckMustHaveElements()
        {
            object[] arrayEmpty = { };
            List<object> listEmpty = new List<object>();
            object[] arrayNotEmpty = { new object() };
            List<object> listNotEmpty = new List<object>(arrayNotEmpty);

            Action act1 = () => arrayEmpty.MustHaveElements();
            Action act2 = () => listEmpty.MustHaveElements();
            Action act3 = () => arrayNotEmpty.MustHaveElements();
            Action act4 = () => listNotEmpty.MustHaveElements();

            act1.ShouldThrow<ArgumentException>();
            act2.ShouldThrow<ArgumentException>();
            act3.ShouldNotThrow();
            act4.ShouldNotThrow();
        }
    }
}
