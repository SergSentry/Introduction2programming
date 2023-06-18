/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] calc_row_summ(int[,] array) {
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    int[] column_mean = new int[n];

    for (int i = 0; i < n; i++) {
        column_mean[i] = 0;
        for (int j = 0; j < m; j++) {
            column_mean[i] += array[i, j];
        }
    }

    return column_mean;
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

int get_min_index(int[] array) {
    int min = array[0];
    int index = 0;
    
    for (int i = 1; i < array.Length; i++) {
        if (min > array[i]) {
            min = array[i];
            index = i;
        }
    }
    
    return index;
}


int N = 3;
int M = 4;

int[,] array = generate_array(N, M, 1, 10);
print_array(array);

int[] row_summ = calc_row_summ(array);

int min_summ_index = get_min_index(row_summ);
Console.WriteLine($"row index with min_sum: {min_summ_index}");