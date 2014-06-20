using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.GuardTests
{
    [TestClass]
    public class Guard_WhenArgument_Should
    {
        [TestMethod]
        public void ReturnsArgument_WithTheGivenValueAndName()
        {
            // Act.
            IArgument<int> argument = Guard.WhenArgument<int>(3, "argument");

            // Assert.
            Assert.AreEqual("argument", argument.Name);
            Assert.AreEqual(3, argument.Value);
        }
    }
}