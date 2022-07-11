int a;
int b;
 
Console.WriteLine("Введите первое число: ");
 a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
 b = Convert.ToInt32(Console.ReadLine());
 
    if (a > b)
        {
        Console.WriteLine($"{a} это наибольшее число", a);
        }
 
        else
 
            {
            Console.WriteLine($"{b} это наибольшее число ", b);
            }
 

