//41. Выяснить являются ли три числа сторонами треугольника 

int a = new Random().Next(10,50);
int b = new Random().Next(10,50);
int c = new Random().Next(10,50);
Console.WriteLine ($" a= {a} ;b = {b};c = {c};");
if (a<b+c && b<a+c && c<b+a)
{
Console.WriteLine("Треугольник");
}
else Console.WriteLine( "нет");