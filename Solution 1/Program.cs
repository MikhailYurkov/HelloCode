// 1. По двум заданным числам проверять является ли первое квадратом второго
int n =
int i = 
int is_square(int n)
{
    for(int i = 1; n > 0; i += 2) n -= i;
    return n;
}
Console.WriteLine (is_square);