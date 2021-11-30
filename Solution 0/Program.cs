//0. Вывести квадрат числа
Console.WriteLine ("Задайте число для вычисления квадрата данного числа: ");

int numberA = int.Parse(Console.ReadLine());
int result = numberA * numberA;

Console.WriteLine("Квадрат числа"+" "+ numberA +" "+ "равен" +" " + result);