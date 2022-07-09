// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"  M = 13; N = 20. -> "15, 18"

Console.WriteLine();

        int start = 11;
        int finish = 34;
        Console.WriteLine("Начало отрезка: " + start);
        Console.WriteLine("Конец отрезка: " + finish);
        Console.WriteLine("Числа на отрезке, кратные трем: ");
        for (int number = start; number < finish; number++)
        {
            if (number % 3 == 0)
            {
                Console.Write(number + "\t");
            }
        }