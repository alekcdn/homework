// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

// Console.WriteLine("Задайте величину массива");
Console.WriteLine("Введите номер строки : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца : ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[4, 4];
GetArrayRandom(arr);
PrintMatrix(arr);

if (row > arr.GetLength(0) || column > arr.GetLength(1))
    Console.WriteLine($"Элемента {row} строки и {column} столбца не существует");
else
    Console.WriteLine($"Элемент {row} строки и {column} столбца = {arr[row-1, column-1]}");

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
