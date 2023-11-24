using System.Runtime.CompilerServices;
 
namespace dotnet8.Interceptors
{
    public static class Interception
    {
        [InterceptsLocation(
            filePath: @"C:\git\aarongithub\dotnet8\Program.cs",
            line: 5,
            character: 9)]
        public static void InterceptMethod1(
            this Example example)
        {
            Console.WriteLine("Hello from Interceptor");
        }

        [InterceptsLocation(
        @"C:\git\aarongithub\dotnet8\Program.cs",
            7,
            9)]
        public static void InterceptMethod2(
        this Example example, string name)
        {
            Console.WriteLine($"Hello from Interceptor, {name}");
        }
    }
}
