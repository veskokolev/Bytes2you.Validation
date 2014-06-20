using System;
using Bytes2you.Validation.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Helpers.ComparerTests
{
    [TestClass]
    public class Comparer_EqualsOfT_Should
    {
        [TestMethod]
        public void ReturnTrue_WhenArgumentsAreNull()
        {
            // Arrange.
            object a = null;
            object b = null;
            
            // Act.
            bool result = Comparer.EqualsOfT(a, b);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnTrue_WhenArgumentsAreNotNullAndAreEqual()
        {
            // Arrange.
            int a = 3;
            int b = 3;

            // Act.
            bool result = Comparer.EqualsOfT(a, b);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenFirstArgumentIsNullAndSecondIsNotNull()
        {
            // Arrange.
            object a = null;
            object b = new object();

            // Act.
            bool result = Comparer.EqualsOfT(a, b);

            // Assert.
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenFirstArgumentIsNotNullAndSecondIsNull()
        {
            // Arrange.
            object a = new object();
            object b = null;

            // Act.
            bool result = Comparer.EqualsOfT(a, b);

            // Assert.
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenArgumentsAreNotNullAndAreNotEqual()
        {
            // Arrange.
            object a = new object();
            object b = new object();

            // Act.
            bool result = Comparer.EqualsOfT(a, b);

            // Assert.
            Assert.IsFalse(result);
        }
    }
}