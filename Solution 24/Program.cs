// 24. Найти кубы чисел от 1 до N

int a = 1;
Console.WriteLine("Напишите число: ");
int b = Convert.ToInt32(Console.ReadLine());

while (a <= b)
{
    Console.WriteLine($"куб {a} = "+ Math.Pow(a,3)); 
    a++;
}