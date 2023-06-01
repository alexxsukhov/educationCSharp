/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число: ");

var number = Convert.ToInt32(Console.ReadLine());
var reverse_number = 0;
var copy_number = number;

while (copy_number > 0)
{
    var end_numeric = copy_number % 10;
    copy_number = copy_number / 10;
    reverse_number = reverse_number * 10 + end_numeric;
}

if (number == reverse_number)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");