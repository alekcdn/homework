// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 <= 0) Console.WriteLine($"Ошибка, {num2} - не натуральное число");
else
{
    int result = GetExp(num1, num2);
    Console.WriteLine($"{num1} в степени {num2} = {result}");
}
int GetExp(int number1, int number2)
{
    int res = number1;
    for (int i = 1; i < number2; i++)
    {
        res = res * number1;
    }
    return res;
}
