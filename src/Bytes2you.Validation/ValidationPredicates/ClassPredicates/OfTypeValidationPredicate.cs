using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.ClassPredicates
{
    internal class OfTypeValidationPredicate<T> : ValidationPredicate<T>
        where T : class
    {
        private readonly Type type;

        public OfTypeValidationPredicate(Type type)
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

        protected override string GetMatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.OfTypeMessage, this.type);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.NotOfTypeMessage, this.type);
        }

        protected override bool IsMatch(T value)
        {
            return value == null || type.IsAssignableFrom(value.GetType());
        }
    }
}