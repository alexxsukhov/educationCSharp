/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

double MathPowAnalog(double number, double degree)
{
    double level = 1;
    for (var i = 0; i < degree; i++) level = level * number;

    return level;
}

Console.WriteLine(MathPowAnalog(3, 5));