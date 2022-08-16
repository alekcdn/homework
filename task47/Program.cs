// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте величину массива");
Console.WriteLine("Введите количество строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
GetArrayRandom(arr);
PrintMatrix(arr);

void GetArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintMatrix(double[,] array)
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
