/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
while (true)
{
    Console.Write("Enter the ordinal day of the week [1-7]: ");
    var digit_str = Console.ReadLine();

    int digit;
    if (int.TryParse(digit_str, out digit))
    {
        if (digit < 1 || digit > 7)
            continue;

        if (digit == 6 || digit == 7)
            Console.Write("yes");
        else 
            Console.Write("no");

        break;
    }
}