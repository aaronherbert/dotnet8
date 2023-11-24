// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//used by runtime team in dotnet
// https://www.youtube.com/watch?v=Gv2uBJzBAms&t=68s 8:50
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/inline-arrays


var buffer = new InlineBuffer();
for (int i = 0; i < 10; i++)
{
    buffer[i] = i;
}

foreach (var i in buffer)
{
    Console.WriteLine(i);
}

[System.Runtime.CompilerServices.InlineArray(10)]
public struct InlineBuffer
{
    private int _element0;
}