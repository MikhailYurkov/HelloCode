// 56. Написать программу, которая обменивает элементы первой строки и последней строки

/*
int[,] CreateIntegerArray(int rowsNumber, int colsNumber)
{
    int[,] arrayToReturn = new int[rowsNumber, colsNumber];
    for (int row = 0; row < rowsNumber; row++)
    {
        for (int col = 0; col < colsNumber; col++)
        {
            arrayToReturn[row, col] = new Random().Next(1, colsNumber);
        }
    }
    return arrayToReturn;
}

void ExchangeRow(int[,] exchangeArroy)
{
    for (int row = 0; row < exchangeArroy.GetLength(0); row++)
    {
        int buffer = exchangeArroy[row, 0];
        exchangeArroy[row, 0] = exchangeArroy[row, exchangeArroy.GetLength(-1) - 1];
        exchangeArroy[row, exchangeArroy.GetLength(-1) - 1] = buffer;
    }

}

void Show2DArray(int[,] arrayToShow, string nameOfArray)
{
    System.Console.WriteLine($"Вывод массива {nameOfArray}");
    for (int row = 0; row < arrayToShow.GetLength(0); row++)
    {
        for (int col = 0; col < arrayToShow.GetLength(1); col++)
        {
            Console.Write($"[{row}][{col}]: {arrayToShow[row, col]} \t");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}
int [,] TestArray = CreateIntegerArray(4, 5);
Show2DArray(TestArray, "Original");
ExchangeRow(TestArray);
Show2DArray(TestArray, "Changed");

*/
//Написать программу, которая обменивает элементы первой строки и последней строки

int[,] CreateIntegerArray(int rowsNumber, int colsNumber)
{
    int[,] arrayToReturn = new int[rowsNumber, colsNumber];
    for (int row = 0; row < rowsNumber; row++)
    {
        for (int col = 0; col < colsNumber; col++)
        
void Show2DArray(int[,] arrayToShow, string nameOfArray)
            {
                System.Console.WriteLine($"Вывод массива {nameOfArray}");
                for (int row = 0; row < arrayToShow.GetLength(0); row++)
                {
                    for (int col = 0; col < arrayToShow.GetLength(1); col++)
                    {
                        Console.Write($"[{row}][{col}]: {arrayToShow[row, col]} \t");
                    }
                    Console.WriteLine();
                }
                System.Console.WriteLine();
            }
    }

    int[,] TestArray = CreateIntegerArray(4, 5);
    Show2DArray(TestArray, "Original");
    ExchangeRow(TestArray);
    Show2DArray(TestArray, "Changed");

