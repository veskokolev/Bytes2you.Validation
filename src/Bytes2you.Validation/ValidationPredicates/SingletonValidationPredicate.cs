using System;
using System.Linq;
using Bytes2you.Validation.Extensions;

namespace Bytes2you.Validation.ValidationPredicates
{
    public abstract class SingletonValidationPredicate<TPredicate, TArgument> : ValidationPredicate<TArgument>
        where TPredicate : IValidationPredicate
    {
        private static readonly Lazy<TPredicate> lazyInstance;

        static SingletonValidationPredicate()
        {
            lazyInstance = new Lazy<TPredicate>(() => (TPredicate)Activator.CreateInstance(typeof(TPredicate), true));
        }

        public static TPredicate Instance
        {
            get
            {
                if (!lazyInstance.IsValueCreated)
                {
                    ValidateTPredicate();  
                }
                
                return lazyInstance.Value;
            }
        }

        private static void ValidateTPredicate()
        {
            Type predicateType = typeof(TPredicate);

            if (predicateType.HasPublicConstructors())
            {
                throw new InvalidOperationException(
                    string.Format("The type '{0}' must not have any public constructors.", predicateType.FullName));
            }
        }
    }
}