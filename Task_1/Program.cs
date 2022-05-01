// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = int.Parse (Console.ReadLine ());
int b = int.Parse (Console.ReadLine ());

int max = a;
int min = b;

if (a < b)
{
    max = b;
    min = a;
}

Console.WriteLine ($"max = {max}, min = {min}");
