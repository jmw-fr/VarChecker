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
    /// Test class of <see cref="NullChecker"/>.
    /// </summary>
    public class NullCheckerTest
    {
        /// <summary>
        /// Test of <see cref="NullChecker.CannotBeNotNull{T}(T, string)"/>
        /// </summary>
        [Fact]
        public void CheckIsNotNull()
        {
            object val1 = null;
            object val2 = new object();

            Action act1 = () => val1.CannotBeNotNull();
            Action act2 = () => val1.CannotBeNotNull<NullReferenceException, object>();
            Action act3 = () => val2.CannotBeNotNull();
            Action act4 = () => val2.CannotBeNotNull<NullReferenceException, object>();

            act1.ShouldThrow<ArgumentNullException>();
            act2.ShouldThrow<NullReferenceException>();
            act3.ShouldNotThrow();
            act4.ShouldNotThrow();
        }
    }
}
