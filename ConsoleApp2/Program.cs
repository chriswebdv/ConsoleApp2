
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
    Console.WriteLine("\n");

    var isGameOn = true;

    do
    {
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
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
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
    } while (isGameOn);
    
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
            Console.WriteLine("You answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You answer is incorrect! Type any key for the next question");
            Console.ReadLine();
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
            Console.WriteLine("You answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You answer is incorrect! Type any key for the next question");
            Console.ReadLine();
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
            Console.WriteLine("You answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You answer is incorrect! Type any key for the next question");
            Console.ReadLine();
        }
        if (i == 4) Console.WriteLine($"Game over, your final score is {score}");
    }
}
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0;i < 5;i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("You answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You answer is incorrect! Type any key for the next question");
            Console.ReadLine();
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
