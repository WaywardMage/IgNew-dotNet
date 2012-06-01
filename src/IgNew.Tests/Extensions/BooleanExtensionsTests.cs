// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BooleanExtensionsTests.cs" company="IgNew LLC">
//   Copywright (c) 2012 IgNew LLC. All rights reserved.
// </copyright>
// <summary>
//   Unit tests for <see cref="BooleanExtensions" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IgNew.Extensions.Tests
{
    #region Using Directives

    using IgNew.Extensions;

    using NUnit.Framework;

    #endregion

    /// <summary>
    /// Unit tests for <see cref="BooleanExtensions"/>.
    /// </summary>
    [TestFixture]
    public class BooleanExtensionsTests
    {
        #region Methods

        #region ToString

        [Test]
        public void Test_ToString_true()
        {
            var trueString = "true";
            var falseString = "false";

            Assert.That(true.ToString(trueString, falseString), Is.EqualTo(trueString));
        }

        [Test]
        public void Test_ToString_false()
        {
            var trueString = "true";
            var falseString = "false";

            Assert.That(false.ToString(trueString, falseString), Is.EqualTo(falseString));
        }

        #endregion

        #endregion
    }
}