Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int second_numeric = number / 10 % 10;

Console.WriteLine($"Искомая цифра: {second_numeric}");