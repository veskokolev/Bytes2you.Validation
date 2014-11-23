using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.OfTypeValidationPredicateTests
{
    [TestClass]
    public class OfTypeValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsStringAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            OfTypeValidationPredicate<string> validationPredicate = new OfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is of type System.String.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsStringAndTypeIsObject()
        {
            // Arrange.
            Type type = typeof(object);
            OfTypeValidationPredicate<string> validationPredicate = new OfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("asdf");

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is of type System.Object.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNullAndTypeIsArrayList()
        {
            // Arrange.
            Type type = typeof(ArrayList);
            OfTypeValidationPredicate<string> validationPredicate = new OfTypeValidationPredicate<string>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is of type System.Collections.ArrayList.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsObjectAndTypeIsString()
        {
            // Arrange.
            Type type = typeof(string);
            OfTypeValidationPredicate<object> validationPredicate = new OfTypeValidationPredicate<object>(type);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(new object());

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is not of type System.String.", result.Message);
        }
    }
}