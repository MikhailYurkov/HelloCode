// Найти сумму элементов от M до N, N и M заданы
int a = 15;
int b = 4;
static void Number(int a, int b);
if(a < b)
{
   Console.WriteLine(""+ a);
    (a<b) Number(a+1, b);
}
else 
{
        Console.WriteLine("" + b);
    (a < b) Number(a, b - 1);
}
Number(a, b);