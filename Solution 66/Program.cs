// 66. Показать натуральные числа от 1 до N, N задано

int a = 1;
int b = 11;

static void Magic(int a, int b)
{
    Console.WriteLine(""+ a);
    if (a<b) Magic(a+1, b);
}

Magic (a,b);