using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatableArgumentTests
{
    [TestClass]
    public class ValidatableArgument_Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenNameArgumentIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidatableArgument<int> argument = new ValidatableArgument<int>(null, 3);
            }, "name");
        }

        [TestMethod]
        public void ThrowException_WhenNameIsEmpty()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidatableArgument<int> argument = new ValidatableArgument<int>(string.Empty, 3);
            }, "name");
        }

        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            string name = "name";
            int value = 5;

            // Act.
            ValidatableArgument<int> argument = new ValidatableArgument<int>(name, value);

            // Assert.
            Assert.AreEqual(name, argument.Name);
            Assert.AreEqual(value, argument.Value);
            Assert.IsFalse(argument.ValidationRules.Any());
        }

        [TestMethod]
        public void CopiesAllProperties_FromTheGivenIArgument()
        {
            // Arrange.
            IArgument<int> argument = new ValidatableArgument<int>("name", 5);

            // Act.
            ValidatableArgument<int> validatableArgument = new ValidatableArgument<int>(argument);

            // Assert.
            Assert.AreEqual(argument.Name, validatableArgument.Name);
            Assert.AreEqual(argument.Value, validatableArgument.Value);
        }
    }
}