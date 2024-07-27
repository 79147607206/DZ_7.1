// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System;

public class Program
{
    public static void PrintRange(int m, int n)
    {
        if (m > n)
            return;

        Console.WriteLine(m);
        PrintRange(m + 1, n);
    }

    public static void Main()
    {
        int m = 5;
        int n = 10;

        PrintRange(m, n);
    }
}