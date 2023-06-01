Console.Title = "Buying inventory";

while (true)
{
    Console.Write("Think of a number and type it here: ");
    string input = Console.ReadLine();

    if (input == "quit" || input == "exit")
    {
        break;
    }

    int number = Convert.ToInt32(input);

    if (number == 12)
    {
        Console.WriteLine("I don't like that number. Pick another one.");
        continue;
    }
    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
}