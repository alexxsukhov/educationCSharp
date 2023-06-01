/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

//Функция генерации массива случайных целых чисел заданное пользователем

int[] GenerateArray(int countElements, int start = 0, int end = 100)
{
    var array = new int[countElements];
    var random = new Random();
    for (var i = 0; i < countElements; i++) array[i] = random.Next(start, end);

    return array;
}

//Чтение данных из консоли
Console.Write("Введите количество элементов для генерации массива: ");
var usrCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний интервал случайных чисел: ");
var start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний интервал случайных чисел: ");
var end = Convert.ToInt32(Console.ReadLine());

var userArray = new int[usrCount];

userArray = GenerateArray(usrCount, start, end);

//Функция вывода массива в формате [a1, a2,a3, ..., ai]
void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]}, ");

    Console.Write("]");
    Console.WriteLine("");
}

PrintArray(userArray);