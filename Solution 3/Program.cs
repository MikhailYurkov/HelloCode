// 3. По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели (1-7): ");
string DayOfWeek = Console.ReadLine();

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