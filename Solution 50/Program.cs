// 50. В двумерном массиве n×k заменить четные элементы на противоположные


double[,] mass = new double[4, 4];
Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        mass[i, j] = random.Next(-100, 100) / 10.00;
        Console.WriteLine("{0,15}", mass[i, j]);
    }
    Console.WriteLine();
}
for (int i = 0)

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(0); j++)
        {
            if (mass[i, j]) % 2 == 0,0000000000001)
        {
    mass[i, j] = -mass[i, j]
        }
    }
}
Console.WriteLine();


void PrintArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]}  ");
        }
        Console.WriteLine();
    }
}
