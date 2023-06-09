/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] make_product_array(int[] array)
{
    if (array.Length == 0)
        return new int[0];
    else if (array.Length == 1)
        return new int[1] { array[0] };

    int half_len = array.Length / 2;
    int new_array_len = (array.Length & 0x1) == 1 ? half_len + 1 : half_len;
    int[] product_array = new int[new_array_len];

    int k = 0;
    for (int i = 0, j = array.Length - 1; i < half_len; i++, j--)
        product_array[k++] = array[i] * array[j];

    if ((array.Length & 0x1) == 1)
        product_array[k] = array[half_len];

    return product_array;
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

int LENGTH = 5;
int[] array = generate_array(LENGTH, 0, 10);
print_array(array);
int[] result = make_product_array(array);
print_array(result);