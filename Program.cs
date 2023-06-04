
int AskForNumber(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

AskForNumber("What's the max seed of a Tesla Plaid?");

int AskForNumberInRange(string text, int min, int
    max)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < min || number > max)
    {
        Console.WriteLine(text);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

AskForNumberInRange("Write a number between 0 and 30", 0, 30);


