
Arrow arrow = getArrow();
Console.WriteLine($"The total cost of your arrow is {arrow.Cost}");

Arrow getArrow()
{
    Console.WriteLine("Do you want to create a custom arrow? (y/n): ");
    string input = Console.ReadLine();
    while (input != "y" && input != "n")
    {
        Console.WriteLine("Do you want to create a custom arrow? (y/n): ");
        input = Console.ReadLine();
    }
    if (input == "y")
    {
        return getCustomArrow();
    }
    else
    {
        Arrowhead arrowhead = GetArrowType();
        Fletching fletching = GetFletchingType();
        float length = GetLength();

        return new Arrow(arrowhead, fletching, length);
    }
        
}

Arrow getCustomArrow()
{
    Console.WriteLine("Which custom arrow do you want to choose?");
    Console.WriteLine("1: \"The Elite Arrow\"");
    Console.WriteLine("2: \"The Beginner Arrow\"");
    Console.WriteLine("3: \"The Marksman Arrow\"");
    Console.Write("Your choose: ");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        return Arrow.CreateEliteArrow();
    } 
    else if (input == 2)
    {
        return Arrow.CreateBeginnerArrow();
    }
    else {
        return Arrow.CreateMarksmanArrow();
    }
}

Fletching GetFletchingType()
{
    Console.WriteLine("Which fletching do you want?");
    Console.WriteLine("(plastic, turkey feathers, goose feathers)");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };
}

Arrowhead GetArrowType()
{
    Console.WriteLine("Which arrowhead do you want?");
    Console.WriteLine("(steel, wood, obsidian)");
    string input = Console.ReadLine();

    return input switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}



float GetLength()
{
    float length = 0;

    while (length < 60 && length > 100)
    {
        Console.WriteLine("Which length do you want? Choose between 60 and 100");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;
}

class Arrow
{
    private Arrowhead Arrowhead { get; }
    private Fletching Fletching { get; }
    private float Length { get; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public static Arrow CreateEliteArrow()
    {
        Arrowhead Arrowhead = Arrowhead.Steel;
        Fletching Fletching = Fletching.Plastic;
        float Length = 95;

        return new Arrow(Arrowhead, Fletching, Length);
    }

    public static Arrow CreateBeginnerArrow()
    {
        Arrowhead Arrowhead = Arrowhead.Wood;
        Fletching Fletching = Fletching.GooseFeathers;
        float Length = 75;

        return new Arrow(Arrowhead, Fletching, Length);
    }

    public static Arrow CreateMarksmanArrow()
    {
        Arrowhead Arrowhead = Arrowhead.Steel;
        Fletching Fletching = Fletching.GooseFeathers;
        float Length = 65;

        return new Arrow(Arrowhead, Fletching, Length);
    }

    public float Cost
    {
        get
        {
            float arrowheadCost = Arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            float fletchingCost = Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            float shaftCost = 0.05f * Length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }


}



enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }