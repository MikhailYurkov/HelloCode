﻿// Написать программу вычисления значения функции y = f(a)
/*
Получить с клавиатуры значение x.
Если x больше 0, то вычислить выражение 2*x-10, результат присвоить переменной y.
Иначе если x равен 0, то присвоить y значение 0.
Иначе присвоить y результат выражения 2*|x|-1.
Вывести значение y на экран.
*/
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = 0;

if (x > 0)
{
    y = 2 * x - 10;
}
else if (x < 0)
{
    y = 2 * x - 1;
}

Console.WriteLine(y);
