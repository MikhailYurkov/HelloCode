// 21. Программа проверяет пятизначное число на палиндромом (12321).

int v = 12321;
var p = v.ToString();
bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}
if (IsPalindrome(p))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("НЕ Палиндром");