Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
bool isLong = isLong(userChoice);

var result = Add(10, 5);
Console.WriteLine(result);

Console.ReadKey();

int Add(int a, int b)
{
    return a + b;
}



bool IsLong(string text)
{
    return input.Length > 10;
}
