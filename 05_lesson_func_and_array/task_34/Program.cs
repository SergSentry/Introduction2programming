/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] generate_array(int n)
{
    if (n <= 0)
        return new int[0];

    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int count_even_number(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] & 0x1) == 0)
            counter++;
    }
    return counter;
}

void print_array(int[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len; i++)
    {
        if (i < len - 1)
            Console.Write("{0}, ", array[i]);
        else
            Console.Write("{0}", array[i]);
    }
    Console.WriteLine("]");
}

int LENGTH = 8;
int[] array = generate_array(LENGTH);
print_array(array);
int count = count_even_number(array);
Console.WriteLine(count);
