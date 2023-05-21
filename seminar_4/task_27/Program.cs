/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int MathSumNumerics(int number)
{
    int summary = 0;
    while (number > 0)
    {
        int numeric = number % 10;
        number = number / 10;
        summary = summary + numeric;
    }
    return summary;
}

Console.WriteLine(MathSumNumerics(12345));