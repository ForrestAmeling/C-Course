//Ask user to prove a number
//Take user imput number
//Ask user for second number
//Then ask user if they want to add, subtract, multiply or divide
//Based on users choice the application will calculate the result
//Reult will be sting so we need to parse it to int
//Print the result
//press any key to close

Console.WriteLine("Hello!");
Console.WriteLine("Please input first numnber:");
int firstNumber = int.Parse(Console.ReadLine());    
Console.WriteLine("Please input second numnber:");  
int secondNumber = int.Parse(Console.ReadLine());   
Console.WriteLine("Please choose one of the following options:");   
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
Console.WriteLine("[D]ivide");
string userChoice = Console.ReadLine();

//Interpolated Strings $"" - allows to use variables inside the string
if (userChoice == "A" || userChoice == "a")
{
    Console.WriteLine($"Result: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
}
else if (userChoice == "S" || userChoice == "s")
{
    Console.WriteLine($"Result: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
}
else if (userChoice == "M" || userChoice == "m")
{
    Console.WriteLine($"Result: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
} else if (userChoice == "D" || userChoice == "d" && secondNumber != 0)
{
    Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
} else if (userChoice == "D" || userChoice == "d" && secondNumber == 0)
{
    Console.WriteLine("You can not divide by 0");
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();




