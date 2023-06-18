Point.Main();

Point newPoint = new Point();
Console.WriteLine(newPoint.X);
Console.WriteLine(newPoint.Y);

Point secondPoint = new Point(13, 43);
Console.WriteLine(secondPoint.X);
Console.WriteLine(secondPoint.Y);


class Point
{
    public int X { get; private set; } = 0;
    public int Y { get; private set; } = 0;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(){}

    public static void Main()
    {
        Point one = new Point(2, 3);
        Point two = new Point(-4, 0);

        Console.WriteLine($"Coords of point one ({one.X}, {one.Y})");
        Console.WriteLine($"Coords of point two ({two.X}, {two.Y})");
    }

}