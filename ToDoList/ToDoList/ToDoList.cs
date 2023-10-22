Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if(userChoice == "S")
{
    Console.WriteLine("Selected option: See all your TODOs:");  
} else if (userChoice == "A")
{
    Console.WriteLine("Selected option: Add a TODO:");
} else if (userChoice == "R")
{
    Console.WriteLine("Selected option: Remove a TODO:");
} else if (userChoice == "E")
{
    Console.WriteLine("Selected option: Exit:");
} else
{
    Console.WriteLine("Invalid option");
}


Console.ReadKey();


