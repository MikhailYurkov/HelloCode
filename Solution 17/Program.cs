//17. По двум заданным числам проверять является ли одно квадратом другого

//int a = 11;
//int b = 14;
Console.Write("введите число a: ");

int a = int.Parse(Console.ReadLine());

Console.Write("введите число b: ");

int b = int.Parse(Console.ReadLine());

int c = 0;
if (a > b)
{
    c = b * a;
}
if (c == a)
{
    Console.WriteLine("Первое является квадратом второго");
}
else if (a < b)
{
    c = a * a;
}
if (c == b)
    Console.WriteLine("Не является квадратом второго");
