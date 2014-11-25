using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.NotInstanceOfTypeValidationPredicateTests
{
    [TestClass]
    public class NotInstanceOfTypeValidationPredicate_Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenTypeArgumentIsNull()
        {
            // Arrange.
            Type type = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                new NotInstanceOfTypeValidationPredicate<string>(type);
            }, "type");
        }

        [TestMethod]
        public void SetTheGivenTypeToTheTypeProperty_WhenTypeArgumentIsNotNull()
        {
            // Arrange.
            Type type = typeof(object);

            // Act.
            NotInstanceOfTypeValidationPredicate<string> validationPredicate = new NotInstanceOfTypeValidationPredicate<string>(type);

            // Assert.
            Assert.AreEqual(type, validationPredicate.Type);
        }
    }
}