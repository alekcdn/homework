// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int GetSumOpt(int[,] arr)
{
    int sum = 0;
    int length = 0;
    if(arr.GetLength(0) >= arr.GetLength(1)) length = arr.GetLength(1);
    else length = arr.GetLength(0);
    for (int j = 0; j < length; j++)
        sum += arr[j,j];
    
    return sum;
}
