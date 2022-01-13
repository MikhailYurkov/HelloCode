// 8. Показать четные числа от 1 до N

Console.WriteLine("Введите число больше 1: ");

int n = int.Parse(Console.ReadLine());
int a = 1;
for (int i = a; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
/*
while (a < b)
{
    Console.Write(a);
    a++;
}
*/