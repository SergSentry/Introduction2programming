/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] generate_array(int n, int m, int start, int end) {
    if (n <= 0 || m <= 0)
        return new int[0, 0];

    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++) {
            array[i, j] = new Random().Next(start, end);
        }

    return array;
}

int[,] multiplication(int[,] a, int[,] b) {
    int an = a.GetLength(0);
    int am = a.GetLength(1);
    int bn = b.GetLength(0);
    int bm = b.GetLength(1);

    if (am != bn) 
        return new int[0,0];

    int[,] r = new int[an, bm];
    for (int i = 0; i < an; i++) {
        for (int j = 0; j < bm; j++) {
            for (int k = 0; k < bn; k++) {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }

    return r;
}

void print_array(int[,] array) {
    Console.Write("{");

    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++) {
        Console.Write("{");
        for (int j = 0; j < m; j++) {
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


int N = 2;
int M = 2;

int[,] array_one = generate_array(N, M, 1, 10);
print_array(array_one);
Console.WriteLine("*");

int[,] array_two = generate_array(N, M, 1, 10);
print_array(array_two);
Console.WriteLine("=");

int[,] result = multiplication(array_one, array_two);
print_array(result);
