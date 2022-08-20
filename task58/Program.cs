// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задайте параметры матриц");
Console.WriteLine("Введите количество строк матрицы 0 : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 0 : ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк матрицы 1 : ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 1 : ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[row, column];
int[,] arr1 = new int[row1, column1];
int[,] newArr = new int[row, column1];

if (column != row1)
{
    Console.WriteLine("Такие матрицы не согласованы!");
    Console.WriteLine("Число столбцов матрицы 0 не равно числу строк матрицы 1. ");
}
else
{
    GetArrayRandom(arr);
    Console.WriteLine("Матрица 0:");
    PrintMatrix(arr);
    GetArrayRandom(arr1);
    Console.WriteLine("Матрица 1:");
    PrintMatrix(arr1);
    MultyMatrix(arr, arr1, newArr);
    Console.WriteLine("Произведение матриц (0 X 1):");
    PrintMatrix(newArr);

    void GetArrayRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = Convert.ToInt32(new Random().Next(-10, 10));
    }

    void PrintMatrix(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == 0) Console.Write("[");
                {
                    if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4}, ");
                    else Console.Write($"{array[i, j],4}]");
                }
            }
            Console.WriteLine();
        }
    }

    void MultyMatrix(int[,] array1, int[,] array2, int[,] newArray)
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                int res = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    res += array1[i, k] * array2[k, j];
                }
                newArray[i, j] = res;
            }
    }
}