Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "какаша")
{
    Console.WriteLine("Иди, смойся в унитаз!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}