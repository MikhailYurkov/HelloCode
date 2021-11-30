// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine ("Введите номер дня недели");

int n = int.Parse(Console.ReadLine());
if (n>7 | n<1)
{
    Console.WriteLine ("Такого дня недели не существует");
}
else
{
    if (n==6 || n==7)
    {
    Console.WriteLine ("Выходной");
    }
    else
    {
    Console.WriteLine ("Будний день");
    }
}