using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Bytes2you.Validation")]
[assembly: AssemblyCompany("bytes2you")]
[assembly: AssemblyProduct("Bytes2you.Validation")]
[assembly: AssemblyDescription("Fast, extensible, intuitive and easy-to-use C# portable library providing fluent APIs for argument validation. Gives everything you need to implement defensive programming in your .NET application")]
[assembly: AssemblyCopyright("Copyright bytes2you©  2014")]

[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("2.0.0.0")]

#if RELEASEOFFICIAL
[assembly: InternalsVisibleTo("Bytes2you.Validation.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100fb4c5f265a35a3663c6df836e7ad646764d02962973f8d7b3584f35f1d68b8f0beb4f5a3a21140a3051bdd4b83e66ab86c1379ec237b89286f79a591ca975f73a06a60d4b5c232131add54ecc7e3e568da05b7fefde172961baa5d10736fad3b88f3d4b105cae46234ebb9b442b902a535fd78405ef972c17199549b735f72ea")]
#else
[assembly: InternalsVisibleTo("Bytes2you.Validation.UnitTests")]
#endif

#if RELEASEOFFICIAL
[assembly: AssemblyConfiguration("ReleaseOfficial")]
#elif DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif