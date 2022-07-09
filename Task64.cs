// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"  M = 13; N = 20. -> "15, 18"

Console.WriteLine();

int M = 11;
int N = 34;

for (int number = M; number < N; number++)
{
    if (number%3 == 0) return number;
    Console.WriteLine(number);
}
