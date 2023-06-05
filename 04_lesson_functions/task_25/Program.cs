/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double pow(long number, long degree) {
    if (degree == 0)
        return 1;
    else if (degree == 1)
        return number;
    else
    {
        long digit = number;
        long abs_degree = degree < 0? -degree: degree;

        for(long i = 1; i < abs_degree; i++)
            digit *= number;

        return degree > 0 ? digit: 1.0/digit;
    }
}

long get_number(string title)
{
    while (true)
    {
        Console.Write(title);
        var digit_str = Console.ReadLine();

        long digit;
        if (long.TryParse(digit_str, out digit))
        {
            return digit;
        }
    }
}

long number = get_number("Enter number: ");
long degree = get_number("Enter degree: ");

Console.WriteLine("pow({0},{1}) = {2}", number, degree, pow(number, degree));
