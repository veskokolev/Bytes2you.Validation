using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Helpers.LazyTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenNameArgumentIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                Lazy<object> lazy = new Lazy<object>(null);
            }, "valueFactory");
        }
    }
}