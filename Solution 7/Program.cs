// 7. Показать числа от -N до N
Console.WriteLine("Введите целое число от: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число до: ");
int b = Convert.ToInt32(Console.ReadLine());

while (a < b)
{
    Console.Write(a);
    a++;
}