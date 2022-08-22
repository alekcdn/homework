﻿// Задача 68: Напишите программу вычисления функции 
// /Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Задайте натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}
Console.Write($"m = {m}, n = {n} -> A(m, n) = {Akk(m, n)}");