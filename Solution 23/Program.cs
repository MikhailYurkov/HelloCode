// 23. Показать таблицу квадратов чисел от 1 до N 

int a = 1;
Console.WriteLine("Напишите число: ");
int b = Convert.ToInt32(Console.ReadLine());

while (a <= b)
{
    Console.WriteLine($"квадрат {a} = "+ Math.Pow(a,2)); 
    a++;
}