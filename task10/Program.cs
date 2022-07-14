// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число : ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > -100 && n < 100 || n > 999 || n < -999)
     {
        Console.WriteLine("Ошибка, это не трёхзначное число");
     } 
     else
        {
            int secondDigit = Math.Abs( n % 100) / 10;
            Console.WriteLine("Вторая цифра = {0}", secondDigit);
        }   

