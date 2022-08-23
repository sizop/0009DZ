//#1
/*
Console.WriteLine("Вводимое количество чисел - ?");
int M = Convert.ToInt32(Console.ReadLine());
double[] array = new double[M];
int count = 0;
for (int i = 0; i < M; i++)
{
	Console.WriteLine($"Введите число # -  {i + 1}");
	array[i] = Convert.ToDouble(Console.ReadLine());
	if (array[i] > 0) count++;
}
Console.WriteLine($"Количество введеных положительных чисел = {count}");
*/
//#2

Console.Write("k1= ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 =");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 =");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 =");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых ({x}, {y})");


