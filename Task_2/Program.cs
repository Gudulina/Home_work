// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = int.Parse (Console.ReadLine ());
int b = int.Parse (Console.ReadLine ());
int c = int.Parse (Console.ReadLine ());

int max = a;
int min = b;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

if (a < min)
{
    min = a;
}

if (c < min)
{
    min = c;
}
Console.WriteLine ($"max = {max}, min = {min}");