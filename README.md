Bytes2you.Validation
==============
Fast, extensible, intuitive and easy-to-use C# portable library providing fluent APIs for argument validation. Gives everything you need to implement defensive programming (http://veskokolev.com/2014/04/27/defensive-programming-technique-the-way-to-fast-failure/) in your .NET applications. 

Supported Frameworks
==============
The supported frameworks are:
    - .NET Framework 4 and higher; 
    - Silverlight 4 and higher; 
    - Windows Phone 7 and higher; 
    - .NET for Windows Store apps; 
    - Xbox 360.

Installation
==============
The library is available in the NuGet Gallery [here](https://www.nuget.org/packages/Bytes2you.Validation/). 
Just type: PM> Install-Package Bytes2you.Validation

API
==============
```cs
Guard.WhenArgument(argument, "argument").Rule1().Rule2()...RuleN().Throw();
```
Based on the argument type there are different things that we can validate that make sense for that type (such as IsEmpty validation for string/guid/collection, etc.).

Examples:
Instead of...

```cs
public void SomeMethod(string stringArgument)
{
    if (string.IsNullOrEmpty(stringArgument))
    {
        throw new ArgumentException("Argument is null or empty string.", "stringArgument");
    }
    
    if (stringArgument == "xxx")
    {
        throw new ArgumentException("Argument is equal to \"xxx\"", "stringArgument");
    }
}
```

...we can use
```cs
public void SomeMethod(string stringArgument)
{
    Guard.WhenArgument(stringArgument, "stringArgument").IsNullOrEmpty().IsEqual("xxx").Throw();
    // Which means - when stringArgument is null or empty OR is equal to "xxx" we should throw exception.
}
```

Rules List
==============
```cs
Guard.WhenArgument<T>(argument, "argument")
```

For all T:
```cs
  .IsEqual(value);
  .IsNotEqual(value);
```

When T is class:
```cs
  .IsNull();
  .IsNotNull();
  .IsInstanceOfType(type);
  .IsNotInstanceOfType(type);
```

When T is Nullable:
```cs
  .IsNull();
  .IsNotNull();
```

When T is bool:
```cs
  .IsTrue();
  .IsFalse();
```

When T is IComparable<T>:
```cs
  .IsLessThan(bound);
  .IsGreaterThan(bound);
  .IsLessThanOrEqual(bound);
  .IsGreaterThanOrEqual(bound);
```

When T is IEnumerable:
```cs
  .IsNullOrEmpty();
  .IsNotNullOrEmpty();
```

When T is Guid:
```cs
  .IsEmptyGuid();
  .IsNotEmptyGuid();
```

When T is string:
```cs
  .IsNullOrEmpty();
  .IsNotNullOrEmpty();
  .IsEqual(value, comparisonType);
  .IsNotEqual(value, comparisonType);
```

When T is float/double:
```cs
  .IsNaN();
  .IsNotNaN();
  .IsInfinity();
  .IsNotInfinity();
  .IsPositiveInfinity();
  .IsNotPositiveInfinity();
  .IsNegativeInfinity();
  .IsNotNegativeInfinity();
```

When T is byte/short:
```cs
  .IsEqual(value);
  .IsNotEqual(value);
  .IsLessThan(bound);
  .IsGreaterThan(bound);
  .IsLessThanOrEqual(bound);
  .IsGreaterThanOrEqual(bound);
```

Stable
==============
The codebase is fully covered with unit tests (100% code coverage). Performance tests are also presented ensuring that the library will not affect the performance of your applications.

Extensibility
==============
One can easily add new rules (see ValidationRules namespace) and expose them thought fluent API extensions (see FluentExtensions namespace).
