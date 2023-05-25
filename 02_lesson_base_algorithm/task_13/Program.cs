/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

while (true)
{
    Console.Write("Enter a number: ");
    var digit_str = Console.ReadLine();

    int digit;
    if (int.TryParse(digit_str, out digit))
    {
        if (digit_str.Length < 3)
            Console.Write("there is no third digit");
        else if (digit > 0)
            Console.Write(digit_str[2]);
        else if (digit < 0)
            Console.Write(digit_str[3]);

        break;
    }
}