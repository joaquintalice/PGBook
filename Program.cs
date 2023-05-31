Console.Title = "Watchtower";

Console.Write("Cords X: ");
string inputX = Console.ReadLine();
Console.Write("Cords Y: ");
string inputY = Console.ReadLine();
int cordX = Convert.ToInt32(inputX);
int cordY = Convert.ToInt32(inputY);

if (cordX < 0 && cordY > 0)
{
    Console.WriteLine("The enemy is in the NorthWest!");
}
else if (cordX == 0 && cordY > 0)
{
    Console.WriteLine("The enemy is in the North!");
}
else if (cordX > 0 && cordY > 0)
{
    Console.WriteLine("The enemy is in the NorthEast!");
}
else if (cordX < 0 && cordY == 0)
{
    Console.WriteLine("The enemy is in the West!");
}
else if (cordX > 0 && cordY == 0)
{
    Console.WriteLine("The enemy is in the East!");
}
else if (cordX < 0 && cordY < 0)
{
    Console.WriteLine("The enemy is in the SouthWest!");
}
else if (cordX == 0 && cordY < 0)
{
    Console.WriteLine("The enemy is in the South!");
}
else if (cordX > 0 && cordY < 0)
{
    Console.WriteLine("The enemy is in the SouthEast!");
}
else
{
    Console.WriteLine("The enemy is here!");
    Console.Beep();
}