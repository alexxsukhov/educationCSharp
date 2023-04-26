Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int third_numeric;
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if(number >= 100 && number < 1000) {
    third_numeric = number % 10;
    Console.WriteLine($"Искомая цифра - {third_numeric}");
}
else
{
    while (number >= 1000) {
        number = number / 10;
    }
    third_numeric = number % 10;
    Console.WriteLine($"Искомая цифра - {third_numeric}");
}