// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица кубов чисел от 1 до {n}");
WriteCubeTable(n);

void WriteCubeTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"| {i} | {i * i * i, 3} |");
        i++;
    }
}
