// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задайте величину массива");
Console.WriteLine("Введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[row, column];

GetArrayRandom(arr);
Console.WriteLine("Исходный массив");
PrintMatrix(arr);

void GetArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 5));
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

int minSum = Int32.MaxValue;
int minSumRow = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{    int sum = 0;
   
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        sum += arr[i, j]; 
    }
    if (sum < minSum)
    {
        minSum = sum;
        minSumRow = i + 1;
    }
}
Console.WriteLine($"Наименьшая сумма элементов в(во) {minSumRow}-й строке => {minSum}");