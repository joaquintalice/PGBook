string GetUserName()
{
    while (true)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (name != "") // Empty string
            return name;
        Console.WriteLine("Let's try that again.");
    }
}

GetUserName();
