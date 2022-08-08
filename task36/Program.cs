// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}
void SumOddElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
int[] array = CreateArrayRndInt(size, min, max);
Console.WriteLine("Создан массив:");
PrintArray(array);
Console.WriteLine();
SumOddElem(array);
