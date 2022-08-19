// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


Console.WriteLine("Задайте величину массива");
Console.WriteLine("Введите X : ");
int par1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y : ");
int par2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z : ");
int par3 = Convert.ToInt32(Console.ReadLine());
int[,,] arr = new int[par1, par2, par3];
GetArrayRandom(arr);
PrintMatrix(arr);

void GetArrayRandom(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = Convert.ToInt32(new Random().Next(10, 99));
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();        
    }
}