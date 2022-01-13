// 22. Найти расстояние между точками в пространстве 2D/3D

int x = 11;
int y = 12;
int z = 15;

int x1 = 16;
int y1 = 17;
int z1 = 13;

double a = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));

double b = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));


Console.WriteLine($"2D = {a}, 3D = {b}");