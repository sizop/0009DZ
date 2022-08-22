//#1
/*
Console.WriteLine("Вводимое количество чисел - ?");
int M = Convert.ToInt32(Console.ReadLine());
double[] array = new double[M];
int count = 0;
for (int i = 0; i < M; i++)
{
	Console.WriteLine($"Введиде число # -  {i + 1}");
	array[i] = Convert.ToDouble(Console.ReadLine());
	if (array[i] > 0) count++;
}
Console.WriteLine($"Количество введеных положительных чисел = {count}");
*/
//#2





















// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
string NumBin = (""); int n = NumBin.Length;
string BinRevers = (""); string mas = ("");  //char[] mas = new char[n];
while (num > 0)
{
	NumBin = NumBin + Convert.ToString(num % 2);
	num = num / 2;
}

for (int i = 0; i < n; i++)
{
	mas = mas+NumBin[i];
}
Console.WriteLine($"mas = {string.Join(" ;",mas)}");
for (int i = n; i != 0; i--)
{
	BinRevers = BinRevers + mas[i - 1];
}


Console.WriteLine($"Строка = {NumBin} ___ {BinRevers}");