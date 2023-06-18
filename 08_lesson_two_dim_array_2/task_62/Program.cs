/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] generate_array(int n, int m, int init_number) {
    if (n != m  || n < 0 || m < 0)
        return new int[0, 0];

    int[,] array = new int[n, m];
    int number = init_number;
    int h = 0, v = 0, step = n;

    while (step > 0) {
        for (int i = v; i <= v + step - 1; i++)
            array[h, i] = number++;

        for (int i = h + 1; i <= h + step - 1; i++)
            array[i, v + step - 1] = number++;
        
        for (int i = v + step - 2; i >= v; i--)
            array[h + step - 1, i] = number++;
        
        for (int i = h + step - 2; i >= h + 1; i--)
            array[i, v] = number++;
        
        h++;
        v++;
        step -= 2;
    }

    return array;
}

void print_array(int[,] array) {
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    int number_len = (n*m).ToString().Length;

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (j < m - 1)
                Console.Write("{0} ", array[i, j].ToString($"D{number_len}"));
            else
                Console.Write("{0}", array[i, j].ToString($"D{number_len}"));
        }

        if (i < n - 1)
            Console.WriteLine();
    }

    Console.WriteLine();
}


int N = 4;
int M = 4;

int[,] array = generate_array(N, M, 1);
print_array(array);
