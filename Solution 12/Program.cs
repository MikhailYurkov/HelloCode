//12. Удалить вторую цифру трёхзначного числа
int a = 459;

int b = a % 10;

int c = a / 100;

Console.WriteLine ( c *10+b);