using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Bytes2you.Validation.ValidationPredicates.EnumPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.EnumPredicates.NotMemberOfEnumValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotMemberOfTheEnum()
        {
            // Arrange.
            CustomEnum value = (CustomEnum)5;

            // Act.
            IValidationPredicateResult result = NotMemberOfEnumValidationPredicate<CustomEnum>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not member of the enum <Bytes2you.Validation.UnitTests.Testing.Mocks.CustomEnum>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsMemberOfTheEnum()
        {
            // Arrange.
            CustomEnum value = CustomEnum.Value2;

            // Act.
            IValidationPredicateResult result = NotMemberOfEnumValidationPredicate<CustomEnum>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <Value2> is member of the enum <Bytes2you.Validation.UnitTests.Testing.Mocks.CustomEnum>.", result.Message);        
        }
    }
}