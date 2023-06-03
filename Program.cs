Console.Title = "The Replicator of D’To";
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Black;
int[] arr = new int[5];
Console.WriteLine("Choose five numbers to fill the array");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write("Number: ");
    int numbersFromUser = Convert.ToInt32(Console.ReadLine());
    arr[i] = numbersFromUser;
    Console.WriteLine("*******************");
    Console.WriteLine($"{arr[i]} was added successfully");
    Console.WriteLine("*******************");
}

Console.BackgroundColor = ConsoleColor.Green;

int[] secondArr = new int[5];
for (int i = 0; i < secondArr.Length; i++)
{
    secondArr[i] = arr[i];
    Console.WriteLine("***************");
    Console.WriteLine($"{secondArr[i]} was copied successfully");
    Console.WriteLine("***************");
}
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;