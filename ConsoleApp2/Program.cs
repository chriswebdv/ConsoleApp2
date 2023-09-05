
using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
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

}
void AdditionGame(string message)
{
    Console.WriteLine(message);

    var Random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = Random.Next(1, 9);
        secondNumber = Random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("You answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("You answer is incorrect!");
        }
        if (i == 4) Console.WriteLine($"Game over, your final score is {score}");
    }   
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var Random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = Random.Next(1, 9);
        secondNumber = Random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("You answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("You answer is incorrect!");
        }
        if (i == 4) Console.WriteLine($"Game over, your final score is {score}");
    }
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var Random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = Random.Next(1, 9);
        secondNumber = Random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("You answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("You answer is incorrect!");
        }
        if (i == 4) Console.WriteLine($"Game over, your final score is {score}");
    }
}
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0;i < 5;i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("You answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("You answer is incorrect!");
        }
        if (i == 4) Console.WriteLine($"Game over, your final score is {score}");
    }
}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];


    while (firstNumber % secondNumber != 0) 
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;
    
    return result;

}
