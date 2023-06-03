Console.Title = "The Magic Cannon";

Console.Write("What number do you want to the length of the array?: ");
int agesLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("*******************");
int[] ages = new int[agesLength];

for (int i = 0; i < ages.Length; i++)
{
    Console.Write("What number do you want to store in the array?: ");
    int num = Convert.ToInt32(Console.ReadLine());
    ages[i] = num;
    Console.WriteLine($"{num} was stored successfully in the array");
}
Console.WriteLine("*******************");
Console.WriteLine("Inverted ages final result: ");

for (int i = 0; i < ages.Length ;i++)
{
    Console.Write($"{ages[^(i+1)]}, ");
}

Console.WriteLine("");
Console.WriteLine("*******************");
int[] range = ages[0..3];
Console.WriteLine("Range 0 to 3");
for (int i = 0; i < range.Length; i++)
{
    Console.WriteLine($"{range[i]}");
}
Console.WriteLine("*******************");
Console.WriteLine("Ages range reverted");
for (int i = 0; i < range.Length; i++)
{
    Console.WriteLine($"{range[^(i+1)]}");
}