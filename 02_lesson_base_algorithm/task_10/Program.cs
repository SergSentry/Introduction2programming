/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

while (true)
{
    Console.Write("Enter a three digit number: ");
    var digit_str = Console.ReadLine();

    int digit;
    if (int.TryParse(digit_str, out digit))
    {
        if (digit > 0 && digit_str.Length == 3)
            Console.Write(digit_str[1]);
        else if (digit < 0 && digit_str.Length == 4)
            Console.Write(digit_str[2]);

        break;
    }
}
