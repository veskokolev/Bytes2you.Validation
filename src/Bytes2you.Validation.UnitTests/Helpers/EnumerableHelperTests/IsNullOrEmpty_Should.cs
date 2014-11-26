using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Helpers.EnumerableHelperTests
{
    [TestClass]
    public class IsNullOrEmpty_Should
    {
        [TestMethod]
        public void ReturnTrue_WhenArgumentIsNull()
        {
            // Arrange.
            IEnumerable enumerable = null;

            // Act.
            bool result = EnumerableHelper.IsNullOrEmpty(enumerable);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnTrue_WhenArgumentIsEmpty()
        {
            // Arrange.
            IEnumerable enumerable = Enumerable.Empty<object>();

            // Act.
            bool result = EnumerableHelper.IsNullOrEmpty(enumerable);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenArgumentIsNotEmpty()
        {
            // Arrange.
            IEnumerable enumerable = new int[] { 1, 2, 3 };

            // Act.
            bool result = EnumerableHelper.IsNullOrEmpty(enumerable);

            // Assert.
            Assert.IsFalse(result);
        }
    }
}