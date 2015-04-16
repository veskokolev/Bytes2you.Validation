using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ClassPredicates
{
    internal class NotInstanceOfTypeValidationPredicate<T> : ValidationPredicate<T>
        where T : class
    {
        private readonly Type type;

        public NotInstanceOfTypeValidationPredicate(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            this.type = type;
        }

        public Type Type
        {
            get
            {
                return this.type;
            }
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
            }
        }

        protected override string GetMatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotInstanceOfTypeMessage, this.type);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.InstanceOfTypeMessage, this.type);
        }

        protected override bool IsMatch(T value)
        {
            return !type.IsInstanceOfType(value);
        }
    }
}