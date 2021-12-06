// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели");

int n = int.Parse(Console.ReadLine());
switch (n)
{
    case > 7:
    case < 1:
        Console.WriteLine("Такого дня недели не существует");
        break;
    case 6:
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Будний день");
        break;
}
