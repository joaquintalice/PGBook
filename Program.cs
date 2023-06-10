
Console.WriteLine($"Which type of food do you want? Choose a num of the menu.");
Console.WriteLine($"1: {FoodType.Soup}");
Console.WriteLine($"2: {FoodType.Stew}");
Console.WriteLine($"3: {FoodType.Gumbo}");
Console.Write("Your choose: ");
int orderNum = Convert.ToInt32(Console.ReadLine());
FoodType typeOrder;
while (orderNum < 1 || orderNum > 3)
{
    Console.Write($"This type isn't in the list. Choose another: ");
    orderNum = Convert.ToInt32(Console.ReadLine());
}

if (orderNum == 1)
{
    typeOrder = FoodType.Soup;
}
else if (orderNum == 2)
{
    typeOrder = FoodType.Stew;
}
else
{
    typeOrder = FoodType.Gumbo;
}

Console.WriteLine($"Which ingredient do you want to your {typeOrder}? Choose a num from the menu");
Console.WriteLine($"1: {MainIngredient.Mushrooms}");
Console.WriteLine($"2: {MainIngredient.Chicken}");
Console.WriteLine($"3: {MainIngredient.Carrots}");
Console.WriteLine($"4: {MainIngredient.Potatoes}");
Console.Write("Your choose: ");
int ingredientNum = Convert.ToInt32(Console.ReadLine());
MainIngredient ingredientOrder;

while (ingredientNum < 1 || ingredientNum > 4)
{
    Console.Write($"This ingredient isn't in the list. Choose another: ");
    ingredientNum = Convert.ToInt32(Console.ReadLine());
}

if (ingredientNum == 1)
{
    ingredientOrder = MainIngredient.Mushrooms;
}
else if (ingredientNum == 2)
{
    ingredientOrder = MainIngredient.Chicken;
}
else if (ingredientNum == 3)
{
    ingredientOrder = MainIngredient.Carrots;
}
else
{
    ingredientOrder = MainIngredient.Potatoes;
}


Console.WriteLine($"Which type of seasoning do you want? Choose a num of the menu.");
Console.WriteLine($"1: {Seasoning.Spicy}");
Console.WriteLine($"2: {Seasoning.Salty}");
Console.WriteLine($"3: {Seasoning.Sweet}");
Console.Write("Your choose: ");
int seasoningNum = Convert.ToInt32(Console.ReadLine());
Seasoning seasoningOrder;

while (seasoningNum < 1 || seasoningNum > 3)
{
    Console.Write($"This type of seasoning isn't in the list. Choose another: ");
    seasoningNum = Convert.ToInt32(Console.ReadLine());
}

if (seasoningNum == 1)
{
    seasoningOrder = Seasoning.Spicy;
}
else if (seasoningNum == 2)
{
    seasoningOrder = Seasoning.Salty;
}
else
{
    seasoningOrder = Seasoning.Sweet;
}

(Seasoning, MainIngredient, FoodType) Soup = (seasoningOrder, ingredientOrder, typeOrder);

Console.WriteLine($"Your {Soup} is ready. Enjoy it!");



enum FoodType
{
    Soup,
    Stew,
    Gumbo
};

enum MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}
