// 25. Найти сумму чисел от 1 до А

int a = 1;
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (a <= b)
{
    summ = a + summ;
    a++;
    Console.WriteLine(summ);

}
Console.WriteLine(summ);
