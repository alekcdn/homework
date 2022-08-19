// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Задайте параметры массивов");
Console.WriteLine("Введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[row, column];
int[,] arr1 = new int[row, column];
int[,] newArr = new int[row, column];

GetArrayRandom(arr);
Console.WriteLine("Первый массив:");
PrintMatrix(arr);
GetArrayRandom(arr1);
Console.WriteLine("Второй массив:");
PrintMatrix(arr1);
MultyMatrix(arr, arr1, newArr);
Console.WriteLine("Произведение массивов:");
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
                if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
                else Console.Write($"{array[i, j],3}]");
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
            {
                res = array1[i, j] * array2[i, j];
            }
            newArray[i, j] = res;
        }
}