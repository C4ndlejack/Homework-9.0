// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

using System;
{
    Console.Write("Введите число m: ");
    int m = Convert.ToInt16(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = Convert.ToInt16(Console.ReadLine());
    static int A(int n, int m)
    {
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return A(n - 1, 1);
        else
        return A(n - 1, A(n, m - 1));
    }
    Console.WriteLine(A(n, m));
}