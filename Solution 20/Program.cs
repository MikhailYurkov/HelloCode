// 20. Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
    Console.WriteLine("x > 0 && y > 0");
else if (x == 2)
    Console.WriteLine("x < 0 && y > 0");
else if (x == 3)
    Console.WriteLine("x < 0 && y > 0");
else if (x == 4)
    Console.WriteLine("x > 0 && y < 0");
else
    Console.WriteLine("Четверть состоит из 4 частей");
