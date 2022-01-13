//6. Выяснить является ли число чётным
/*
Console.WriteLine("введите целое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите целое число:");

int b = Convert.ToInt32(Console.ReadLine());

while (a < b)
{
    Console.Write(a);
    a++;
}*/
Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}