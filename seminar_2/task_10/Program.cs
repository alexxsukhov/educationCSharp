Console.Write("Введите трехзначное число: ");
var number = Convert.ToInt32(Console.ReadLine());

var second_numeric = number / 10 % 10;

Console.WriteLine($"Искомая цифра: {second_numeric}");