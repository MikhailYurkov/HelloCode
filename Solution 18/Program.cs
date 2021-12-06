// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// ¬ - отрицание, не; V - или, +; ⋀ - и, *.

bool[] x = { true, false };
bool[] y = { true, false };
for (int n = 0; n < x.Length; n++)
{
    for (int a = 0; a < y.Length; a++)
    {
        if (!(x[n] || y[a]) == !x[n] && !y[a])
        {
            Console.WriteLine("Истина");
        }
        else
        {
            Console.WriteLine("ЛОжь");
        }
    }
}
