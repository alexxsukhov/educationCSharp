/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int SummaryNumberInRange(int start = 1, int end = 5)
{
    if (start == end)
    {
        return end;
    }

    return start + SummaryNumberInRange(start + 1, end);
}

Console.WriteLine(SummaryNumberInRange());