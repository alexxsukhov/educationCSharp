﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
var a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine($"Число {a} является четным");
else
    Console.WriteLine($"Число {a} является нечетным");