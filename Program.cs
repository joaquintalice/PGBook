Console.Title = "The Laws of Freach";

int[,] matriz = new int[3, 10];

for (int i = 0; i < matriz.GetLength(0); i++)
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

