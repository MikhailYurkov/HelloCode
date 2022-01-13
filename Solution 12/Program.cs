//12. Удалить вторую цифру трёхзначного числа
int a = new Random().Next(100, 1000);
Console.WriteLine("Число: " + a);
int b = a % 10;

int c = a / 100;

Console.WriteLine(c * 10 + b);