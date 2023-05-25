/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int digit_n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < digit_n; i++)
{
    if ((i & 1) > 0)
        continue;

    Console.Write("{0} ", i);
}