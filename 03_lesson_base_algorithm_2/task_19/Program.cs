/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
while (true)
{
    Console.Write("Enter a five-digit number: ");
    var digit_str = Console.ReadLine();

    int digit;
    if (int.TryParse(digit_str, out digit))
    {
        if (digit_str.Length != 5)
            continue;

        if (digit_str[0] == digit_str[4]
           && digit_str[1] == digit_str[3])
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");

        break;
    }
}