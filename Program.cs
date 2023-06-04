Console.Title = "The Laws of Freach";

int[,] matriz = new int[3,3];

for (int fila = 0; fila < matriz.GetLength(0); fila++)
{
    for (int columna = 0; columna < matriz.GetLength(0); columna++)
    {
        Console.Write("Put a number in the matrix: ");
        matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The value in the [{fila}, {columna}] is {matriz[fila, columna]}. ");
    }
    Console.WriteLine();

}
Console.WriteLine("************************************************************");
for (int fila = 0; fila < matriz.GetLength(0); fila++)
{
    for (int columna = 0; columna < matriz.GetLength(0); columna++)
    {
        Console.Write(matriz[fila, columna] + " ");
    }
    Console.WriteLine();

}