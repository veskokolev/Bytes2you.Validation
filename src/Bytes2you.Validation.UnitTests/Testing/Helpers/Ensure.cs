using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Testing.Helpers
{
    internal static class Ensure
    {
        public static void ArgumentExceptionIsThrown(Action action, string expectedArgumentName, string expectedMessage = null)
        {
            if (action == null)
            {
                throw new ArgumentNullException("method");
            }

            if (string.IsNullOrEmpty(expectedArgumentName))
            {
                throw new ArgumentException("expectedArgumentName");
            }

            ArgumentException ex = null;
            try
            {
                action();
            }
            catch (ArgumentException e)
            {
                ex = e;
            }

            Assert.IsNotNull(ex);
            Assert.AreEqual(expectedArgumentName, ex.ParamName);

            if (expectedMessage != null)
            {
                Assert.AreEqual(ex.Message, expectedMessage);
            }
        }

        public static void ArgumentNullExceptionIsThrown(Action action, string expectedArgumentName)
        {
            if (action == null)
            {
                throw new ArgumentNullException("method");
            }

            if (string.IsNullOrEmpty(expectedArgumentName))
            {
                throw new ArgumentException("expectedArgumentName");
            }

            ArgumentNullException ex = null;
            try
            {
                action();
            }
            catch (ArgumentNullException e)
            {
                ex = e;
            }

            Assert.IsNotNull(ex);
            Assert.AreEqual(expectedArgumentName, ex.ParamName);
        }

        public static void NoExceptionIsThrown(Action action)
        {
            if (action == null)
            {
                throw new ArgumentNullException("method");
            }

            try
            {
                action();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        public static void ActionRunsInExpectedTime(Action action, int repeatCount, int expectedTimeInMilliseconds)
        {
            if (action == null)
            {
                throw new ArgumentNullException("method");
            }

            if (repeatCount <= 0)
            {
                throw new ArgumentException("repeatCount");
            }

            if (expectedTimeInMilliseconds <= 0)
            {
                throw new ArgumentException("expectedTimeInMilliseconds");
            }

            Stopwatch watch = new Stopwatch();

            for (int i = 0; i < repeatCount; i++)
            {
                watch.Start();

                action();

                watch.Stop();
            }

            string assertionMessage = string.Format(
                "The given action does not perform as expected. repeatCount: {0}; expectedTimeInMilliseconds: {1}; actualTimeInMilliseconds: {2}", 
                repeatCount, 
                expectedTimeInMilliseconds, 
                watch.ElapsedMilliseconds);

            Assert.IsTrue(watch.ElapsedMilliseconds < expectedTimeInMilliseconds, assertionMessage);
        }
    }
}