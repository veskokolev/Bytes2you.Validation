using System;
using System.Linq;

namespace Bytes2you.Validation.UnitTests.Testing.Mocks
{
    internal class IntArgumentMock : IArgument<int>
    {
        public string Name
        {
            get
            {
                return "ArgumentMock";
            }
        }

        public int Value
        {
            get
            {
                return 5;
            }
        }
    }
}