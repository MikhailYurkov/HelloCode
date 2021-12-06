// 2. Даны два числа. Показать большее и меньшее число

int A = new Random().Next(1, 99);

int B = new Random().Next(1, 99);
Console.WriteLine(A);
Console.WriteLine(B);
int max = A;
if (A > max) max = A;
if (B > max) max = B;
Console.Write("max = ");
Console.WriteLine(max);