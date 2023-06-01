Console.Write("Введите число от 1 до 7: ");
var numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay < 1 || numberDay > 7)
    Console.WriteLine("Число не явлется днем недели");
else if (numberDay > 5 && numberDay <= 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Будний день");