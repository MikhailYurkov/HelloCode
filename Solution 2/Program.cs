// 2. Даны два числа. Показать большее и меньшее число

int A = new Random().Next(1, 99);

int B = new Random().Next(1, 99);
<<<<<<< HEAD
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
=======
Console.WriteLine(A);
Console.WriteLine(B);
int max = A;
if (A > max) max = A;
if (B > max) max = B;
Console.Write("max = ");
Console.WriteLine(max);
>>>>>>> 930a802529df54d64e3f8ddf0adc7f77d65bb414
