// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine ("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 6;

if (num1 % num2 == 0)
{
    Console.WriteLine ("Числа кратны");
}
else
{
    Console.WriteLine ("Числа не кратны " + "Остаток " + (num1 % num2));
}
