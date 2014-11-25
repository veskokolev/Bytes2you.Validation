using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.InstanceOfTypeValidationPredicateTests
{
    [TestClass]
    public class InstanceOfTypeValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsStringAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            InstanceOfTypeValidationPredicate<string> validationPredicate = new InstanceOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is instance of type <System.String>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsStringAndTypeIsObject()
        {
            // Arrange.
            Type type = typeof(object);
            InstanceOfTypeValidationPredicate<string> validationPredicate = new InstanceOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is instance of type <System.Object>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNullAndTypeIsArrayList()
        {
            // Arrange.
            Type type = typeof(ArrayList);
            InstanceOfTypeValidationPredicate<string> validationPredicate = new InstanceOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is not instance of type <System.Collections.ArrayList>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsObjectAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            InstanceOfTypeValidationPredicate<object> validationPredicate = new InstanceOfTypeValidationPredicate<object>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(new object());

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is not instance of type <System.String>.", result.Message);
        }
    }
}