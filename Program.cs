Console.WriteLine("Hello, World!");

var x = new Person("bob");

x.Hello();

public class Person(string _name)
{
    public void Hello()
    {
        Console.WriteLine($"Hello {_name}");

        _name = "asd";
    }

}
 