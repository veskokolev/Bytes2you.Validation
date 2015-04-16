using System;
using System.Diagnostics;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
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

            if (expectedArgumentName == null)
            {
                throw new ArgumentNullException("expectedArgumentName");
            }

            if (expectedArgumentName == string.Empty)
            {
                throw new ArgumentException(ValidationPredicateMessages.NullOrEmptyStringMessage, "expectedArgumentName");
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

            Assert.AreEqual(typeof(ArgumentException), ex.GetType());
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

            if (expectedArgumentName == null)
            {
                throw new ArgumentNullException("expectedArgumentName");
            }

            if (expectedArgumentName == string.Empty)
            {
                throw new ArgumentException(ValidationPredicateMessages.NullOrEmptyStringMessage, "expectedArgumentName");
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

            Assert.AreEqual(typeof(ArgumentNullException), ex.GetType());
            Assert.IsNotNull(ex);
            Assert.AreEqual(expectedArgumentName, ex.ParamName);
        }

        public static void ArgumentOutOfRangeExceptionIsThrown(Action action, string expectedArgumentName)
        {
            if (action == null)
            {
                throw new ArgumentNullException("method");
            }

            if (expectedArgumentName == null)
            {
                throw new ArgumentNullException("expectedArgumentName");
            }

            if (expectedArgumentName == string.Empty)
            {
                throw new ArgumentException(ValidationPredicateMessages.NullOrEmptyStringMessage, "expectedArgumentName");
            }

            ArgumentOutOfRangeException ex = null;
            try
            {
                action();
            }
            catch (ArgumentOutOfRangeException e)
            {
                ex = e;
            }

            Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType());
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
            catch (Exception)
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
                throw new ArgumentException("The argument is less than or equal to 0.", "repeatCount");
            }

            if (expectedTimeInMilliseconds <= 0)
            {
                throw new ArgumentException("The argument is less than or equal to 0.", "expectedTimeInMilliseconds");
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