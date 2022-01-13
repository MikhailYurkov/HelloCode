// 10. Показать вторую цифру трёхзначного числ
int number = new Random().Next(100, 1000);
int a = number % 10;
Console.WriteLine("Число: " + number);
int b = (number % 100 - number % 10) / 10;
Console.WriteLine("Десятки: " + b);
Console.ReadKey(true);