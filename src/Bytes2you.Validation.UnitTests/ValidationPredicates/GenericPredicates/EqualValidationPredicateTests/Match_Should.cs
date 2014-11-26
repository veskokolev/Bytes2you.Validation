using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.GenericPredicates.EqualValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsEqual()
        {
            // Arrange.
            EqualValidationPredicate<int> validationPredicate = new EqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(3);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotEqual()
        {
            // Arrange.
            EqualValidationPredicate<int> validationPredicate = new EqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsNullAndArgumentIsNull()
        {
            // Arrange.
            EqualValidationPredicate<string> validationPredicate = new EqualValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsNullAndArgumentIsNotNull()
        {
            // Arrange.
            EqualValidationPredicate<string> validationPredicate = new EqualValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("a");

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <a> is not equal to <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsNotNullAndArgumentIsNull()
        {
            // Arrange.
            EqualValidationPredicate<string> validationPredicate = new EqualValidationPredicate<string>("a");

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <null> is not equal to <a>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsDoublePositiveInfinityAndArgumentIsPositiveInfinity()
        {
            // Arrange.
            EqualValidationPredicate<double> validationPredicate = new EqualValidationPredicate<double>(double.PositiveInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(double.PositiveInfinity);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to <Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsDoublePositiveInfinityAndArgumentIsNegativeInfinity()
        {
            // Arrange.
            EqualValidationPredicate<double> validationPredicate = new EqualValidationPredicate<double>(double.PositiveInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(double.NegativeInfinity);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <-Infinity> is not equal to <Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsDoublePositiveInfinityAndArgumentIsNotInfinity()
        {
            // Arrange.
            EqualValidationPredicate<double> validationPredicate = new EqualValidationPredicate<double>(double.PositiveInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not equal to <Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsDoubleNegativeInfinityAndArgumentIsNegativeInfinity()
        {
            // Arrange.
            EqualValidationPredicate<double> validationPredicate = new EqualValidationPredicate<double>(double.NegativeInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(double.NegativeInfinity);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to <-Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsDoubleNegativeInfinityAndArgumentIsPositiveInfinity()
        {
            // Arrange.
            EqualValidationPredicate<double> validationPredicate = new EqualValidationPredicate<double>(double.NegativeInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(double.PositiveInfinity);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <Infinity> is not equal to <-Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsDoubleNegativeInfinityAndArgumentIsNotInfinity()
        {
            // Arrange.
            EqualValidationPredicate<double> validationPredicate = new EqualValidationPredicate<double>(double.NegativeInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not equal to <-Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsFloatPositiveInfinityAndArgumentIsPositiveInfinity()
        {
            // Arrange.
            EqualValidationPredicate<float> validationPredicate = new EqualValidationPredicate<float>(float.PositiveInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(float.PositiveInfinity);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to <Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsFloatPositiveInfinityAndArgumentIsNegativeInfinity()
        {
            // Arrange.
            EqualValidationPredicate<float> validationPredicate = new EqualValidationPredicate<float>(float.PositiveInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(float.NegativeInfinity);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <-Infinity> is not equal to <Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsFloatPositiveInfinityAndArgumentIsNotInfinity()
        {
            // Arrange.
            EqualValidationPredicate<float> validationPredicate = new EqualValidationPredicate<float>(float.PositiveInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not equal to <Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsFloatNegativeInfinityAndArgumentIsNegativeInfinity()
        {
            // Arrange.
            EqualValidationPredicate<float> validationPredicate = new EqualValidationPredicate<float>(float.NegativeInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(float.NegativeInfinity);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to <-Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsFloatNegativeInfinityAndArgumentIsPositiveInfinity()
        {
            // Arrange.
            EqualValidationPredicate<float> validationPredicate = new EqualValidationPredicate<float>(float.NegativeInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(float.PositiveInfinity);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <Infinity> is not equal to <-Infinity>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsFloatNegativeInfinityAndArgumentIsNotInfinity()
        {
            // Arrange.
            EqualValidationPredicate<float> validationPredicate = new EqualValidationPredicate<float>(float.NegativeInfinity);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not equal to <-Infinity>.", result.Message);
        }
    }
}