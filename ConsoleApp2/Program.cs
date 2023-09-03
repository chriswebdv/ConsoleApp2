Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that your working in improving yourself!");
Console.WriteLine($@"What game would you like to play? Choose below.
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit out");
Console.WriteLine("------------------------------------------------");

var gameSelected = Console.ReadLine();

switch (gameSelected.Trim().ToLower())
{
    case "a":
        AdditionGame("Addition game selected"); 
        break;
    case "s":
        SubtractionGame("Subtraction game selected");
        break;
    case "m":
        MultiplicationGame("Multiplication game selected");
        break;
    case "d":
        DivisionGame("Division game selected");
        break;
    case "q":
        Console.WriteLine("Goodbye");
        Environment.Exit(1);
        break;
    default:
        Console.WriteLine("Invalid request");
        Environment.Exit(1);
        break;
}

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid Input");
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
}