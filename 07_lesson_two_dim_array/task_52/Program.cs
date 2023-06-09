/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] generate_array(int n, int m, int start, int end)
{
    if (n <= 0 || m <= 0)
        return new int[0, 0];

    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(start, end);
        }

    return array;
}

double[] calc_column_mean(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    double[] column_mean = new double[m];

    for (int i = 0; i < m; i++)
    {
        double summ = 0.0;
        for (int j = 0; j < n; j++)
        {
            summ += array[j, i];
        }
        column_mean[i] = summ / n;
    }

    return column_mean;
}

void print_array(int[,] array)
{
    Console.Write("{");
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        Console.Write("{");
        for (int j = 0; j < m; j++)
        {
            if (j < m - 1)
                Console.Write("{0}, ", array[i, j]);
            else
                Console.Write("{0}", array[i, j]);
        }

        if (i < n - 1)
            Console.Write("},\n");
        else
            Console.Write("}");
    }
    Console.WriteLine("}");
}

void print_column_mean(double[] array)
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


int N = 3;
int M = 4;
int[,] array = generate_array(N, M, 1, 10);
print_array(array);
double[] column_mean = calc_column_mean(array);
print_column_mean(column_mean);