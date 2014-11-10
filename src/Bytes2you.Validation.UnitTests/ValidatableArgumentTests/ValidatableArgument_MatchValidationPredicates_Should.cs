using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatableArgumentTests
{
    [TestClass]
    public class ValidatableArgument_MatchValidationPredicates_Should
    {
        [TestMethod]
        public void ReturnEnumerableEmpty_WhenValidationPredicatesCollectionIsEmpty()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);

            // Act.
            IEnumerable<IValidationPredicateResult> validationPredicateResults = argument.MatchValidationPredicates();

            // Assert.
            Assert.IsFalse(validationPredicateResults.Any());
        }

        [TestMethod]
        public void ReturnValidationPredicateResults_WhenValidatinoPredicatesCollectionIsNotEmpty()
        {
            // Arrange.
            IntValidationPredicateMock validationPredicate1 = new IntValidationPredicateMock();
            IntValidationPredicateMock validationPredicate2 = new IntValidationPredicateMock();
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);

            argument.AddValidationPredicate(validationPredicate1);
            argument.AddValidationPredicate(validationPredicate2);

            // Act.
            IEnumerable<IValidationPredicateResult> validationPredicateResults = argument.MatchValidationPredicates();

            // Assert.
            Assert.AreEqual(2, validationPredicateResults.Count());
            validationPredicate1.AssertIsMatchCalls(5);
            validationPredicate2.AssertIsMatchCalls(5);
        }
    }
}