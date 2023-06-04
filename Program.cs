Console.Title = "The Laws of Freach";

int[,] matriz = new int[3, 10];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"Ingrese el valor para la matriz [{i}, {j}]: ");
        int value = Convert.ToInt32(Console.ReadLine());
        matriz[i, j] = value;
        
    }
    Console.WriteLine();
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

int[] result = new int[10];
for (int i = 0; i < matriz.GetLength(0); i++)
{
    result[i] = 0;
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        result[i] += matriz[i, j];
    }
    Console.Write($"Suma de la fila {i}: ");
    Console.Write(result[i] + " ");
    Console.WriteLine();
}