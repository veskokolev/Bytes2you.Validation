using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.NotInstanceOfTypeValidationPredicateTests
{
    [TestClass]
    public class NotInstanceOfTypeValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsStringAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            NotInstanceOfTypeValidationPredicate<string> validationPredicate = new NotInstanceOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is instance of type <System.String>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnatchMessage_WhenArgumentIsStringAndTypeIsObject()
        {
            // Arrange.
            Type type = typeof(object);
            NotInstanceOfTypeValidationPredicate<string> validationPredicate = new NotInstanceOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is instance of type <System.Object>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNullAndTypeIsArrayList()
        {
            // Arrange.
            Type type = typeof(ArrayList);
            NotInstanceOfTypeValidationPredicate<string> validationPredicate = new NotInstanceOfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is not instance of type <System.Collections.ArrayList>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsObjectAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            NotInstanceOfTypeValidationPredicate<object> validationPredicate = new NotInstanceOfTypeValidationPredicate<object>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(new object());

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is not instance of type <System.String>.", result.Message);
        }
    }
}