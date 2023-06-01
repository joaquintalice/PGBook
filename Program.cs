Console.Title = "Buying inventory";

Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("The following items are available:");
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Write("What number do you want to see the price of?: ");
Console.BackgroundColor = ConsoleColor.Red;
int itemID = Convert.ToInt32(Console.ReadLine());
Console.Write("What's your name?: ");
string name = Console.ReadLine();
Console.BackgroundColor = ConsoleColor.Black;

switch (itemID)
{
    case 1:
        if (name == "Joaquin")
        {
            Console.WriteLine("Rope cost 5 gold");
        }
        else
        {
            Console.WriteLine("Rope cost 10 gold");
        }
        break;

    case 2:
        if (name == "Joaquin")
        {
            Console.WriteLine("Torches cost 8 gold");
        }
        else
        {
            Console.WriteLine("Torches cost 16 gold");
        }
        break;

    case 3:
        if (name == "Joaquin")
        {
            Console.WriteLine("Climbing Equipment cost 12 gold");
        }
        else
        {
            Console.WriteLine("Climbing Equipment cost 24 gold");
        }
        break;

    case 4:
        if (name == "Joaquin")
        {
            Console.WriteLine("Clean Water cost 1 gold");
        }
        else
        {
            Console.WriteLine("Clean Water cost 2 gold");
        }
        break;

    case 5:
        if (name == "Joaquin")
        {
            Console.WriteLine("Machete cost 10 gold");
        }
        else
        {
            Console.WriteLine("Machete cost 20 gold");
        }
        break;

    case 6:
        if (name == "Joaquin")
        {
            Console.WriteLine("Canoe cost 100 gold");
        }
        else
        {
            Console.WriteLine("Canoe cost 200 gold");
        }
        break;

    case 7:
        if (name == "Joaquin")
        {
            Console.WriteLine("Food Supplies cost 1 gold");
        }
        else
        {
            Console.WriteLine("Food Supplies cost 2 gold");
        }
        break;

    default:
        Console.WriteLine("This item isn't available");
        break;
}