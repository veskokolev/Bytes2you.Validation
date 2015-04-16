using System;
using System.Linq;
using Bytes2you.Validation.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Helpers.StringHelperTests
{
    [TestClass]
    public class IsNullOrWhiteSpace_Should
    {
        [TestMethod]
        public void ReturnTrue_WhenArgumentIsNull()
        {
            // Arrange.
            string value = null;

            // Act.
            bool result = StringHelper.IsNullOrWhiteSpace(value);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnTrue_WhenArgumentIsStringEmpty()
        {
            // Arrange.
            string value = string.Empty;

            // Act.
            bool result = StringHelper.IsNullOrWhiteSpace(value);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnTrue_WhenArgumentConsistsOnlyOfWhiteSpaceCharacters()
        {
            // Arrange.
            string value = "   \t\r\n   ";

            // Act.
            bool result = StringHelper.IsNullOrWhiteSpace(value);

            // Assert.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenArgumentConsistsOnlyOfNonWhiteSpaceChars()
        {
            // Arrange.
            string value = "asdf";

            // Act.
            bool result = StringHelper.IsNullOrWhiteSpace(value);

            // Assert.
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnFalse_WhenArgumentContainsNonWhiteSpaceChars()
        {
            // Arrange.
            string value = "     \r\nasdf";

            // Act.
            bool result = StringHelper.IsNullOrWhiteSpace(value);

            // Assert.
            Assert.IsFalse(result);
        }
    }
}