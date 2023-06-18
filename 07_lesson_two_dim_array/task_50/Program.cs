/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        Console.Write("{");
        for (int j = 0; j < m; j++)
        {
            if (j < m - 1)
                Console.Write("{0:f2}, ", array[i, j]);
            else
                Console.Write("{0:f2}", array[i, j]);
        }

        if (i < n - 1)
            Console.Write("},\n");
        else
            Console.Write("}");
    }
    Console.WriteLine("}");
}

bool check_position(int n, int m, int row, int col)
{
    if (n <= 0 || m <= 0)
        return false;

    return (row >= 0 && n > row) && (col >= 0 && m > col);
}

void print_value(double[,] array, int row, int col)
{
    Console.WriteLine("{0:f2}", array[row, col]);
}

void print_no_found()
{
    Console.WriteLine("No found");
}


int N = 3;
int M = 4;

double[,] array = generate_array(N, M, 0, 100);
print_array(array);

int row = get_number("Input row=");
int col = get_number("Input col=");

if (check_position(N, M, row, col))
    print_value(array, row, col);
else
    print_no_found();