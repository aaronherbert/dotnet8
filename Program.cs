// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var example = new Example();

var age = 30;

example.Test(ref age);

Console.WriteLine($"The age is: {age}");

class Example()
{
    public void Test(ref readonly int age)
    {
        Console.WriteLine($"The age is: {age}");
        age++;
    }
}