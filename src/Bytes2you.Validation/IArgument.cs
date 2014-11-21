using System;
using System.ComponentModel;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IArgument<T>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        string Name { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        T Value { get; }
    }
}