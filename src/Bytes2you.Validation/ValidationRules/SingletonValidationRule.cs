using System;
using System.Linq;
using Bytes2you.Validation.Extensions;

namespace Bytes2you.Validation.ValidationRules
{
    public abstract class SingletonValidationRule<TRule, TArgument> : ValidationRule<TArgument>
        where TRule : IValidationRule
    {
        private static Lazy<TRule> lazyInstance;

        static SingletonValidationRule()
        {
            lazyInstance = new Lazy<TRule>(() => (TRule)Activator.CreateInstance(typeof(TRule), true));
        }

        public static TRule Instance
        {
            get
            {
                ValidateTRule();
                return lazyInstance.Value;
            }
        }

        private static void ValidateTRule()
        {
            Type ruleType = typeof(TRule);

            if (ruleType.HasPublicConstructors())
            {
                throw new InvalidOperationException(
                    string.Format("The type '{0}' must not have any public constructors.", ruleType.FullName));
            }
        }
    }
}