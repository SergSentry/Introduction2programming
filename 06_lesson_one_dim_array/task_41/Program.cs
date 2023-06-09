/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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

int[] input_array(int n)
{
    if (n <= 0)
        return new int[0];

    int[] new_array = new int[n];

    for (int i = 0; i < n; i++)
        new_array[i] = get_number($"input digit [{i}] =");

    return new_array;
}

int count_above_zero(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            counter++;
    }
    return counter;
}

void programm()
{
    int user_array_len = get_number("Enter number amount: ");
    while (user_array_len <= 0)
    {
        user_array_len = get_number("Enter number amount: ");
    }

    int[] user_array = input_array(user_array_len);
    int digit_above_zero = count_above_zero(user_array);

    Console.WriteLine(digit_above_zero);
}

programm();