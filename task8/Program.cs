int N;
Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
int i = 1;            
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
	}
	if (i >= N)
	{
		break;
	}
	i++;
}