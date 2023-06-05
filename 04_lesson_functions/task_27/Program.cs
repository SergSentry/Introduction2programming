/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

long digit_summ(long digit) {
    digit = digit < 0 ? -digit: digit;
    
    long summ = 0;
    while (digit > 0)
    {
        long last_number = digit % 10;
        digit -= last_number;
        digit /= 10;
        summ += last_number;
    }

    return summ;
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
Console.WriteLine("sum digit {0} = {1}", number, digit_summ(number));
