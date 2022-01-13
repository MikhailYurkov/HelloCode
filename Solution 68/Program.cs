// Показать натуральные числа от M до N, N и M заданы

string Nummer(int n, int m)
{

    if (n > m)
      {  if (m == n)
        {
            return Convert.ToString(m);
        }
    
        return m + " " + Nummer(m - 1, n);
      }
    else
    {
        if (m == n)
        {
            return Convert.ToString(m);
        }
        return m + " " + Nummer(m + 1, n);
    }
}
Console.Write(Nummer(1, 14));
/*
    Console.Write(" " + n);
    Nummer(n + 1, m);

}
    else if (m > n)
{
    Console.Write(" " + n);
    Nummer(m + 1, n);
}
}
Nummer(n, m);

/*
if (n < m) ;
{
    Nummer(m, n + 1);
    Console.Write(a + 1, m);
}
else if (m < n);
{
    Console.Write(a + 1, m);
    Nummer(m, n - 1);
}
Nummer(n, m);
*/