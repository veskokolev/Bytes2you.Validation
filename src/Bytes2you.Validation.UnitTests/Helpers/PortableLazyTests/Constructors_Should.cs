using System;
using System.Linq;
using Bytes2you.Validation.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Helpers.PortableLazyTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenNameArgumentIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                PortableLazy<object> lazy = new PortableLazy<object>(null);
            }, "valueFactory");
        }
    }
}