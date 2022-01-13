// Показать натуральные числа от N до 1, N задано

int a = 1;
int b = 11;

static void Number(int a, int b)
{
    Console.WriteLine("" + b);
    if (a < b) Number(a, b - 1);
}

Number(a, b);