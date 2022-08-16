// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте величину массива");
Console.WriteLine("Введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[row, column];
GetArrayRandom(arr);
PrintMatrix(arr);
Console.WriteLine("Среднее арифметическое каждого столбца : ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        res = (res + arr[i, j]);
    }
    res = res / row;
    Console.Write(Math.Round(res, 2) + "  ");
}

void GetArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4}, ");
            else Console.Write($"{array[i, j],4}]");
        }
        Console.WriteLine();
    }
}
