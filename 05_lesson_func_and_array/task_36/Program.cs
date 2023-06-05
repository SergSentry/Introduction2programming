/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int summ_odd_index_number(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i & 0x1) == 1)
            summ += array[i];
    }
    return summ;
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

int LENGTH = 10;
int[] array = generate_array(LENGTH, 0, 10);
print_array(array);
int summ = summ_odd_index_number(array);
Console.WriteLine(summ);