/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] generate_array(int n, int start, int end)
{
    if (n <= 0)
        return new double[0];

    double[] array = new double[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(start, end);
        array[i] += new Random().NextDouble();
    }

    return array;
}

double max(double[] array)
{
    if (array.Length == 0)
        return 0;
    else if (array.Length == 1)
        return array[0];

    double max_value = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max_value)
        {
            max_value = array[i];
        }
    }

    return max_value;
}

double min(double[] array)
{
    if (array.Length == 0)
        return 0;
    else if (array.Length == 1)
        return array[0];

    double min_value = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min_value > array[i])
        {
            min_value = array[i];
        }
    }
    
    return min_value;
}

void print_array(double[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len; i++)
    {
        if (i < len - 1)
            Console.Write("{0:f2}, ", array[i]);
        else
            Console.Write("{0:f2}", array[i]);
    }
    Console.WriteLine("]");
}

int LENGTH = 5;
double[] array = generate_array(LENGTH, 0, 10);
print_array(array);

double min_value = min(array);
double max_value = max(array);

Console.WriteLine("{0:f2}", max_value - min_value);