/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] generate_array(int n, int m, int start, int end)
{
    if (n <= 0 || m <= 0)
        return new double[0, 0];

    double[,] array = new double[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(start, end);
            array[i, j] += new Random().NextDouble();
        }

    return array;
}

void print_array(double[,] array)
{
    Console.Write("{");
    for (int i = 0; i < 3; i++)
    {
        Console.Write("{");
        for (int j = 0; j < 4; j++)
        {
            if (j < 4 - 1)
                Console.Write("{0:f2}, ", array[i, j]);
            else
                Console.Write("{0:f2}", array[i, j]);
        }

        if (i < 3 - 1)
            Console.Write("},\n");
        else
            Console.Write("}");
    }
    Console.Write("}");
}

int N = 3;
int M = 4;

double[,] array = generate_array(N, M, 0, 100);
print_array(array);