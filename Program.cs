Color.Main();
class Color
{
    public int R { get; private set; }
    public int G { get; private set; }
    public int B { get; private set; }

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public static Color White
    {
        get { return new Color(255, 255, 255); }
    }

    public static Color Black
    {
        get { return new Color(0, 0, 0); }
    }

    public static Color Red
    {
        get { return new Color(255, 0, 0); }
    }

    public static Color Orange
    {
        get { return new Color(255, 165, 0); }
    }

    public static Color Yellow
    {
        get { return new Color(255, 255, 0); }
    }

    public static Color Green
    {
        get { return new Color(0, 128, 0); }
    }

    public static Color Blue
    {
        get { return new Color(0, 0, 255); }
    }

    public static Color Purple
    {
        get { return new Color(128, 0, 128); }
    }

    public static void Main()
    {
        Color Pink = new Color(255, 182,193);
        Console.WriteLine($"The RGB code of the color Pink is R:{Pink.R} G:{Pink.G} B:{Pink.B}");
        Console.WriteLine($"The RBG code of the color Yellow is R:{Color.Yellow.R} G:{Color.Yellow.G} B:{Color.Yellow.B}");
    }
}