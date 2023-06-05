/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] generate_array(int n, int start, int end)
{
    if (n <= 0)
        return new int[0];

    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(start, end);
    }

    return array;
}

int count_number_in_range(int[] array, int min, int max)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= max && array[i] >= min)
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

int LENGTH = 128;
int MIN_RANGE = 10;
int MAX_RANGE = 99;

int[] array = generate_array(LENGTH, 0, 129);
print_array(array);
int count = count_number_in_range(array, MIN_RANGE, MAX_RANGE);
Console.WriteLine(count);