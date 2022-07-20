// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int firstX, secondX, firstY, secondY, firstZ, secondZ;

Console.Write("Введите координату X точки A : ");
firstX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A : ");
firstY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A : ");
firstZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B : ");
secondX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B : ");
secondY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B : ");
secondZ = Convert.ToInt32(Console.ReadLine());

Console.Write("Расстояние между A и B в 3D = ");
Console.WriteLine(Distance(firstX, firstY, firstZ, secondX, secondY, secondZ));

double Distance(double ax, double ay, double az, double bx, double by, double bz)
{
return Math.Round(Math.Sqrt(((bx-ax) * (bx-ax)  + (by-ay) * (by-ay) + (bz-az) * (bz-az))), 2, MidpointRounding.ToZero);
}
