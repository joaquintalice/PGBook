Console.Title = "Defense of Consolas";
Console.Write("Target row?: ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column?: ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("Deploy to:");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine($"({targetRow + 1}, {targetColumn})");

Console.Beep();