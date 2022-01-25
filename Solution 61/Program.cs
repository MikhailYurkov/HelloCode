// 61. Найти произведение двух матриц
int[,] CreateMatrix(int row, int col)
{
    int[,] Matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Matrix[i, j] = new Random().Next(0, row + col);
        }
    }
    return Matrix;
}
void ShowMatrix(int[,] matrixToShow, string nameOfMatrix)
{
    Console.WriteLine($"Вывод массива {nameOfMatrix}");
    for (int i = 0; i < matrixToShow.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToShow.GetLength(1); j++)
        {
            Console.Write($"{matrixToShow[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (var i = 0; i < matrix1.GetLength(0); i++) //количество строк итоговой матрицы
        {
            for (var j = 0; j < matrix2.GetLength(1); j++) //количество столбцов итоговой матрицы
            {
                for (var k = 0; k < matrix1.GetLength(1); k++) //количество строк/столбцов, которые должна пройти матрица при подсчете
                {
                    resultMatrix[i,j] += matrix1[i,k]*matrix2[k,j];
                }
            }
        }
    return resultMatrix;



    Console.Clear();
    int[,] matrix1 = CreateMatrix(3, 3);
    ShowMatrix(matrix1, "1 matrix");
    int[,] matrix2 = CreateMatrix(3, 3);
    ShowMatrix(matrix2, "2 matrix");
    int[,] resultMatrix;




/*
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)]
    for (int i = 0; i < matrixToShow.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToShow.GetLength(1); j++)
        {
            int[,] resultMatrix = matrix1[i, j] * matrix2[i, j]
        }
    }
    */