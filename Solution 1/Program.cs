// 1. По двум заданным числам проверить является ли первое квадратом второго
Console.WriteLine("Задайте первое число : ");

int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте второе число : ");

int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.Write(numberA + " является квадратом " + numberB);
}
else
{
    Console.Write(numberA + " не является квадратом " + numberB);
}