// <copyright file="NullCheckerTest.cs" company="Weeger Jean-Marc">
// Copyright Weeger Jean-Marc under MIT Licence. See https://opensource.org/licenses/mit-license.php.
// </copyright>

namespace VarChecker.Test
{
    using System;
    using FluentAssertions;
    using Jmw.VarChecker;
    using Xunit;

    /// <summary>
    /// Test class of <see cref="StringChecker"/>.
    /// </summary>
    public class StringCheckerTest
    {
        /// <summary>
        /// Test of <see cref="StringChecker.CannotNotNullOrEmpty(string, string)"/>
        /// </summary>
        [Fact]
        public void CheckIsNotNull()
        {
            string val1 = null;
            string val2 = "";
            string val3 = "val3";

            Action act1 = () => val1.CannotNotNullOrEmpty();
            Action act2 = () => val2.CannotNotNullOrEmpty();
            Action act3 = () => val2.CannotNotNullOrEmpty<Exception>();
            Action act4 = () => val3.CannotNotNullOrEmpty();

            act1.ShouldThrow<ArgumentException>();
            act2.ShouldThrow<ArgumentException>();
            act3.ShouldThrow<Exception>();
            act4.ShouldNotThrow();
        }
    }
}
