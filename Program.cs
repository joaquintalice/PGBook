Console.Title = "The Magic Cannon";

Console.Write("How high should I count?");
int chosenNumber = ReadNumber();
Count(chosenNumber);
void Count(int numberToCountTo)
{
    for (int current = 1; current <= numberToCountTo; current++)
        Console.WriteLine(current);
}
int ReadNumber()
{
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
};

