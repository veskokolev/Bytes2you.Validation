using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Extensions.TypeExtensionsTests
{
    [TestClass]
    public class TypeExtensions_HasPublicConstructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenTypeArgumentIsNull()
        {
            // Arrange.
            Type type = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                type.HasPublicConstructors();
            }, "@type");
        }

        [TestMethod]
        public void ReturnTrue_WhenTypeHasPublicConstructors()
        {
            // Act.
            bool hasPublicConstructor = typeof(TypeWithPublicConstructor).HasPublicConstructors();

            // Assert.
            Assert.IsTrue(hasPublicConstructor);
        }

        [TestMethod]
        public void ReturnFalse_WhenTypeDoesNotHavePublicConstructors()
        {
            // Act.
            bool hasPublicConstructor = typeof(TypeWithPrivateConstructor).HasPublicConstructors();

            // Assert.
            Assert.IsFalse(hasPublicConstructor);
        }
    }
}