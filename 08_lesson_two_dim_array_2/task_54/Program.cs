/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] generate_array(int n, int m, int start, int end) {
    if (n <= 0 || m <= 0)
        return new int[0, 0];

    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            array[i, j] = new Random().Next(start, end);
        }
    }

    return array;
}

void sort_row(int[,] array, int row_index) {
    int m = array.GetLength(1);

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < m - 1; j++) {
            if (array[row_index, j] < array[row_index, j + 1]) {
                int tmp = array[row_index, j + 1];
                array[row_index, j + 1] = array[row_index, j];
                array[row_index, j] = tmp;
            }
        }
    }
}

void sort_array(int[,] array) {
    int n = array.GetLength(0);
    
    for (int i = 0; i < n; i++) {
        sort_row(array, i);
    }
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

int N = 3;
int M = 4;

int[,] array = generate_array(N, M, 1, 10);
print_array(array);

Console.WriteLine();
sort_array(array);

print_array(array);