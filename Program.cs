// See https://aka.ms/new-console-template for more information

var example = new Example();

example.Method1();

example.Method2("name");

public class Example
{
    public void Method1()
    {
        Console.WriteLine("Hello from Method1");
    }

    public void Method2(string name)
    {
        Console.WriteLine($"Hello from Method2, {name}");
    }
}