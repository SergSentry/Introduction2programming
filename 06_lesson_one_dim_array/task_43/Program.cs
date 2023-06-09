/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

float get_number(string title)
{
    while (true)
    {
        Console.Write(title);
        var digit_str = Console.ReadLine();

        float digit;
        if (float.TryParse(digit_str, out digit))
        {
            return digit;
        }
    }
}

float[] get_coef_line(string title)
{
    float[] coef = new float[2];

    Console.WriteLine(title);

    coef[0] = get_number("Input k = ");
    coef[1] = get_number("Input b = ");

    return coef;
}

bool is_line_equal(float[] first_line, float[] second_line)
{
    float delta = 0.000000001F;
    return
    first_line.Length == 2
    && second_line.Length == 2
    && (Math.Abs(first_line[0] - second_line[0]) < delta)
    && (Math.Abs(first_line[1] - second_line[1]) < delta);
}

bool is_line_parallel(float[] first_line, float[] second_line)
{
    float delta = 0.000000001F;
    return
    first_line.Length == 2
    && second_line.Length == 2
    && (Math.Abs(first_line[0] - second_line[0]) < delta)
    && (Math.Abs(first_line[0] - second_line[0]) > delta);
}

bool has_line_intersect(float[] first_line, float[] second_line)
{
    return !is_line_equal(first_line, second_line) && !is_line_parallel(first_line, second_line);
}

float[] calc_intersect(float[] first_line, float[] second_line)
{
    float[] result = new float[2];

    result[0] = (second_line[1] - first_line[1]) / (first_line[0] - second_line[0]);
    result[1] = (first_line[0]*second_line[1] - second_line[0]*first_line[1]) / (first_line[0] - second_line[0]);;

    return result;
}

void print_array(float[] array)
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


float[] first_line = get_coef_line("Input first line coef y = k * x + b");
float[] second_line = get_coef_line("Input second line coef y = k * x + b");

if (has_line_intersect(first_line, second_line))
{
    float[] intersect_line = calc_intersect(first_line, second_line);
    Console.Write("Intersect at");
    print_array(intersect_line);
} else
    Console.WriteLine("No intersect");