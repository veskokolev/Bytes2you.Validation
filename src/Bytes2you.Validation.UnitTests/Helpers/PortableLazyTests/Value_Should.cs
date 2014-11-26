using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.UnitTests.Helpers.PortableLazyTests
{
    [TestClass]
    public class Value_Should
    {
        [TestMethod]
        public void InvokeOnlyOnceValueFactory_WhenValueIsCalled()
        {
            // Arrange.
            int valueFactoryCallCount = 0;
            object value = new object();

            PortableLazy<object> lazy =
                new PortableLazy<object>(
                () => 
                {
                    valueFactoryCallCount++; 
                    return value; 
                });

            // Act & Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(value, lazy.Value);
            }

            Assert.AreEqual(1, valueFactoryCallCount);
        }
    }
}