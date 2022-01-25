// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента


void Create3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int temp = matrix[i, j, k];
                matrix[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
}

void Show3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{i}][{j}][[{k}]:{matrix[i, j, k]}\t");
            }
        Console.WriteLine();
    }
}