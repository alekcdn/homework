// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] CreateArrayRnd()
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
         arr[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return arr;
}
void DiffMinMax(double[] arr)
{
    double max1 = Int32.MinValue;
    double min1 = Int32.MaxValue ;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max1)
        {
            max1 = arr[i];
        }
        if (arr[i] < min1)
        {
            min1 = arr[i];
        }

    }
    Console.WriteLine($"Разница между максимальным {max1} и минимальным {min1} значением = {Math.Round(max1 - min1, 1)}");

}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + "]");
    }
}
double[] array = CreateArrayRnd();
Console.WriteLine("Создан массив:");
PrintArray(array);
Console.WriteLine();
DiffMinMax(array);