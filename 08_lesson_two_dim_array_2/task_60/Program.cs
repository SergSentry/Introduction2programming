/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

bool is_exists(int[] array, int number) {
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == number)
            return true;
    }

    return false;
}

int[,,] generate_array(int n, int m, int z, int start, int end) {
    if (n < 0 || m < 0 || z < 0)
        return new int[0, 0, 0];

    if (end - start < n*m*z)
        return new int[0, 0, 0];

    int[,,] array = new int[n, m, z];
    int[] numbers = new int[n*m*z];

    int index_numbers = 0;

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++) 
            for (int k = 0; k < z; k++) {
                int number = new Random().Next(start, end);

                while (is_exists(numbers, number))
                    number = new Random().Next(start, end);
                
                numbers[index_numbers++] = number;
                array[i, j, k] = number;
        }

    return array;
}

void print_array(int[,,] array) {
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int z = array.GetLength(2);

    for (int k = 0; k < z; k++) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (j < m - 1)
                    Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
                else
                    Console.Write($"{array[i, j, k]} ({i},{j},{k})");
            }
            
            Console.WriteLine();
        }
    }
}


int N = 2;
int M = 2;
int Z = 2;

int[,,] array = generate_array(N, M, Z, 1, N*M*Z + 1);
print_array(array);
