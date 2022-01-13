// 2. Даны два числа. Показать большее и меньшее число

int A = new Random().Next(1, 99);

int B = new Random().Next(1, 99);

Console.WriteLine("число - 1 = "+A);
Console.WriteLine("число  - 2 = "+B);
int max = A;
if (A > max) max = A;
if (B > max) max = B;

int min = A;
if (A < min) min = A;
if (B < min) min = B;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
