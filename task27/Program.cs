// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int SumDig(int num)
{
    int dig = 0;
    int res = 0;
    while (num > 0)
    {
        dig = num % 10;
        res = res + dig;
        num = num / 10;
    }
    return res;
}
int result = SumDig(n);
Console.WriteLine($"Сумма цифр числа {n} равна: {result}");