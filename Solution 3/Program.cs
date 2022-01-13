// 3. По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели (1-7): ");
string DayOfWeek = Console.ReadLine();

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

