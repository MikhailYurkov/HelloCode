// 4. Найти максимальное из трех чисел
int a = new Random().Next(1, 99);
int b = new Random().Next(1, 99);
int c = new Random().Next(1, 99);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max = ");
Console.WriteLine(max);