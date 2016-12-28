using System;
using System.Linq;
using Bytes2you.Validation.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Helpers.EnumHelperTests
{
    [TestClass]
    public class ThrowIfNotEnum_Should
    {
        [TestMethod]
        public void ThrowArgumentException_WhenTEnumIsNotEnumeration()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    EnumHelper.ThrowIfNotEnum<CustomIConvertibleStruct>();
                }, "TEnum");
        }

        [TestMethod]
        public void NoExceptionIsThrown_WhenTEnumIsEnumeration()
        {
            // Act & Assert.
            Ensure.NoExceptionIsThrown(
                () =>
                {
                    EnumHelper.ThrowIfNotEnum<CustomEnum>();
                });
        }
    }
}