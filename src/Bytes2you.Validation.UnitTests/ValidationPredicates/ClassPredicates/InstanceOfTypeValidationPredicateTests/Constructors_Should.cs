using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.InstanceOfTypeValidationPredicateTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenTypeArgumentIsNull()
        {
            // Arrange.
            Type type = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                new InstanceOfTypeValidationPredicate<string>(type);
            }, "type");
        }

        [TestMethod]
        public void SetTheGivenTypeToTheTypeProperty_WhenTypeArgumentIsNotNull()
        {
            // Arrange.
            Type type = typeof(object);

            // Act.
            InstanceOfTypeValidationPredicate<string> validationPredicate = new InstanceOfTypeValidationPredicate<string>(type);

            // Assert.
            Assert.AreEqual(type, validationPredicate.Type);
        }
    }
}