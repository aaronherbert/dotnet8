
//                    👇 7
var lambda7 = (string message) => $"hello {message}";

Console.WriteLine(lambda7("world"));

//                    👇 8
var lambda8 = (string message ="world") => $"hello {message}";

Console.WriteLine(lambda8());