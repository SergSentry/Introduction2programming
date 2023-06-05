/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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

double calc_distance(int a_x, int a_y, int a_z, int b_x, int b_y, int b_z)
{
    return Math.Sqrt(
       Math.Pow(b_x - a_x, 2)
     + Math.Pow(b_y - a_y, 2)
     + Math.Pow(b_z - a_z, 2)
     );
}

int a_x = get_number("Enter coordinate x for point A: ");
int a_y = get_number("Enter coordinate y for point A: ");
int a_z = get_number("Enter coordinate z for point A: ");

int b_x = get_number("Enter coordinate x for point B: ");
int b_y = get_number("Enter coordinate y for point B: ");
int b_z = get_number("Enter coordinate z for point B: ");

double result = calc_distance(a_x, a_y, a_z, b_x, b_y, b_z);

Console.WriteLine("{0:f2}", result);

