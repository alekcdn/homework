int a;
int b;
int c;
int max;

Console.WriteLine("Введите три целых числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("max= {0}", max);