/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int count = 0;

while (true)
{
    Console.WriteLine("Введите число: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber > 0)
    {
        count = count + 1;
    }

    if (userNumber == 0)
    {
        break;
    }
}
Console.WriteLine($"Количество положительных чисел: {count}");



