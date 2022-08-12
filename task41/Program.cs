// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите общее количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

NumbersInput(m);
Console.WriteLine($"Чисел больше нуля -  {CountPositiveNumbers(array)}");

void NumbersInput(int m1)
{
    for (int i = 0; i < m1; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}



