// Найти третью цифру числа или сообщить, что её нет

int number14 = new Random().Next(10, 10000);
Console.WriteLine(number14);
int sot14 = (number14 / 100) % 10;
if (sot14 == 0) Console.WriteLine("текст")
else Console.WriteLine("третья цыфра -" + sot14")



