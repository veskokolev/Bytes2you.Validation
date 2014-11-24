using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.NotOfTypeValidationPredicateTests
{
    [TestClass]
    public class NotOfTypeValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsStringAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            NotOfTypeValidationPredicate<string> validationPredicate = new NotOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is of type <System.String>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnatchMessage_WhenArgumentIsStringAndTypeIsObject()
        {
            // Arrange.
            Type type = typeof(object);
            NotOfTypeValidationPredicate<string> validationPredicate = new NotOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is of type <System.Object>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnatchMessage_WhenArgumentIsNullAndTypeIsArrayList()
        {
            // Arrange.
            Type type = typeof(ArrayList);
            NotOfTypeValidationPredicate<string> validationPredicate = new NotOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is of type <System.Collections.ArrayList>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsObjectAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            NotOfTypeValidationPredicate<object> validationPredicate = new NotOfTypeValidationPredicate<object>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(new object());

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is not of type <System.String>.", result.Message);
        }
    }
}