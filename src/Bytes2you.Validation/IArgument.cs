using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IArgument<T>
    {
        string Name { get; }
        T Value { get; }
    }
}