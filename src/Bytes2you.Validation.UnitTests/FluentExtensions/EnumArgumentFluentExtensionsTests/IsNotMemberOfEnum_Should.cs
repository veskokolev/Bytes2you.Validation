using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Bytes2you.Validation.ValidationPredicates.EnumPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.EnumArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNotMemberOfEnum_Should
    {
        [TestMethod]
        public void ThrowArgumentException_WhenTEnumIsNotEnumeration()
        {
            // Arrange.
            ValidatableArgument<CustomIConvertibleStruct> argument =
                new ValidatableArgument<CustomIConvertibleStruct>("argument", default(CustomIConvertibleStruct));

            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    argument.IsNotMemberOfEnum();
                }, "TEnum");
        }

        [TestMethod]
        public void AddNotMemberOfEnumValidationPredicate_WhenTEnumIsEnumeration()
        {
            // Arrange.
            ValidatableArgument<CustomEnum> argument =
                new ValidatableArgument<CustomEnum>("argument", CustomEnum.Value1);

            // Act.
            argument.IsNotMemberOfEnum();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotMemberOfEnumValidationPredicate<CustomEnum>));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<CustomEnum> argument =
                new ValidatableArgument<CustomEnum>("argument", CustomEnum.Value1);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNotMemberOfEnum();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}