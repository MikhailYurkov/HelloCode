// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
int b1 = 5;
int b2 = 6;
int k1 = 3;
int k2 = 4;

int x = (b2-b1)/(k1-k2);
int y1 = k1*x+b1;
int y2 = k2*x+b2;
if (y1==y2)
Console.WriteLine (y2);
Console.WriteLine ("точка перечесения");
