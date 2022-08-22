// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumNumbers(m, n, 0);

void SumNumbers(int num1, int num2, int sum)
{
    if (num1 <= num2)
    {
    sum += (num1++);
    SumNumbers(num1, num2, sum);
    }
    else
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
    return;
}

