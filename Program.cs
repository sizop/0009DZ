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
/*
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
*/

//#3
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string invnum = "";
while (number > 0)
{
    invnum = invnum + Convert.ToString(number % 2);
    number = number / 2;
}
int len = invnum.Length;
//string [] binum = new string [len];
string bin = "";
for (int i = 0; i < len; i++)
{
   // binum [len-1-i] = invnum[i].ToString();
   bin = bin + invnum[len - 1 - i].ToString();
}
//Console.WriteLine($"В двоичной системе {String.Join("", binum)}");
Console.WriteLine(bin);
