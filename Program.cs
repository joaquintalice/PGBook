Console.Title = "Hunting the Manticore";
int manticoreHealth = 10;
int cityHealth = 15;
int currentRound = 1;

Console.Write("Player 1: How far away from the city do you want to station the Manticore? (0 to 100) ");
int player1Ask = Convert.ToInt32(Console.ReadLine());
while (player1Ask < 0 || player1Ask > 100)
{
    Console.Write($"Player 1: How far away from the city do you want to station the Manticore? (0 to 100). {player1Ask} is an invalid value. ");
    player1Ask = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();

Console.WriteLine("Player 2: it is your turn.");
while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine("***************************************");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"STATUS: Round: {currentRound} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    cannonInfo();
    range();

    cityHealth--;
    currentRound++;
    Console.WriteLine("***************************************");
}

if (cityHealth > 0)
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Nice! We win the battle versus Uncoded One's airship.");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
} 
else
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Uncoded One's win the battle and destroy the city of Consolas");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
}

;
void range()
{
    Console.Write("Enter desired cannon range: ");
    int player2Ask = Convert.ToInt32(Console.ReadLine());

    if (player2Ask == player1Ask)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        cannonDmg();
    }
    else if (player2Ask > player1Ask)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void cannonDmg()
{
    if (currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        manticoreHealth -= 10;
    }
    else if (currentRound % 3 == 0 || currentRound % 5 == 0)
    {
        manticoreHealth -= 3;
    }
    else
    {
        manticoreHealth -= 1;
    }
}

void cannonInfo()
{
    if (currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 10 damage this round.");
    }
    else if (currentRound % 3 == 0 || currentRound % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 3 damage this round.");
    }
    else
    {
        Console.WriteLine("The cannon is expected to deal 1 damage this round.");
    }
}
