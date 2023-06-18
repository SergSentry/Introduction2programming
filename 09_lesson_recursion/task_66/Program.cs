/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int calc_summ(int m, int n) {
    if (m == n)
        return m; 

    return m + calc_summ(m + 1, n);
}

int M = 1;
int N = 15;

int result = 0;
result = calc_summ(M, N);
Console.WriteLine(result);
