Console.Title = "The prototype";

Console.Write("User 1, enter a number between 0 and 100: ");
int userOneNumber = Convert.ToInt32(Console.ReadLine());

while (userOneNumber < 0 || userOneNumber > 100)
{
    Console.Write("User 1, invalid number, please enter a number between 0 and 100: ");
    userOneNumber = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

Console.Write("User 2, guess the number: ");
int userTwoNumber = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (userTwoNumber > userOneNumber)
    {
        Console.WriteLine($"{userTwoNumber} is too high.");
    }
    else if (userTwoNumber < userOneNumber)
    {
        Console.WriteLine($"{userTwoNumber} is too low.");
    }
    else
    {
        Console.WriteLine($"{userTwoNumber} is correct! You guessed the number!");
        break;
    }
    Console.Write("User 2, what is your next guess?: ");
    userTwoNumber = Convert.ToInt32(Console.ReadLine());
}