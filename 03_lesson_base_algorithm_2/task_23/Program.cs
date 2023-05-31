/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
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

int n = get_number("Enter digits amount: ");

for (int i = 1; i <= n; i++)
{
    if (i == n)
        Console.Write("{0}", Math.Pow(i, 3));
    else
        Console.Write("{0}, ", Math.Pow(i, 3));
}
