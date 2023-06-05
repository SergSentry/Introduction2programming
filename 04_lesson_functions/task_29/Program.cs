/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int get_number(string title)
{
    while (true)
    {
        Console.Write(title);
        var digit_str = Console.ReadLine();

        int digit;
        if (int.TryParse(digit_str, out digit))
        {
            return digit;
        }
    }
}

int[] input_array(int n)
{
    if (n <= 0)
        return new int[0];

    int[] new_array = new int[n];

    for (int i = 0; i < n; i++)
        new_array[i] = get_number($"input digit [{i}] =");

    return new_array;
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
int[] array = input_array(LENGTH);
print_array(array);
