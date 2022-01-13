// 3. По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели (1-7): ");
string DayOfWeek = Console.ReadLine();

<<<<<<< HEAD
if (DayOfWeek == "1")
    Console.WriteLine("Понедельник");
else if  (DayOfWeek == "2")
    Console.WriteLine("Вторник");
else if (DayOfWeek == "3")
    Console.WriteLine("Среда");
else if  (DayOfWeek == "4")
    Console.WriteLine("Четверг");
else if  (DayOfWeek == "5")
    Console.WriteLine("Пятница");
else if  (DayOfWeek == "6")
    Console.WriteLine("Суббота");
else if  (DayOfWeek == "7")
    Console.WriteLine("Воскресенье");
else Console.WriteLine("Такого дня недели нет");

=======
if (DayOfWeek.ToLower() == "1")
{
    Console.WriteLine("Понедельник");
}
if (DayOfWeek.ToLower() == "2")
{
    Console.WriteLine("Вторник");
}
if (DayOfWeek.ToLower() == "3")
{
    Console.WriteLine("Среда");
}
if (DayOfWeek.ToLower() == "4")
{
    Console.WriteLine("Четверг");
}
if (DayOfWeek.ToLower() == "5")
{
    Console.WriteLine("Пятница");
}
if (DayOfWeek.ToLower() == "6")
{
    Console.WriteLine("Суббота");
}
if (DayOfWeek.ToLower() == "7")
{
    Console.WriteLine("Воскресенье");
}
>>>>>>> 930a802529df54d64e3f8ddf0adc7f77d65bb414
