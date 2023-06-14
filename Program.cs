
Arrow arrow = getArrow();
Console.WriteLine($"The total cost of your arrow is {arrow.Cost}");

Arrow getArrow()
{
    Arrowhead arrowhead = GetArrowType();
    Fletching fletching = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
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