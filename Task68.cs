// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine();
double AckermannFunc(double m, double n)
{
    if (m == 0) return n + 1;
    else
    if (n == 0) return AckermannFunc(m - 1, 1);
    else
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}
Console.WriteLine(AckermannFunc(3, 2));
Console.WriteLine();