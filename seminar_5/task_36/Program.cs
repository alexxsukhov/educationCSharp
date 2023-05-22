/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */
 
int[] GenerateArray(int countElements, int start = 0, int end = 100)
{
    int[] array = new int[countElements];
    Random random = new Random();
    for (int i = 0; i < countElements; i++)
    {
        array[i] = random.Next(start, end);
    }
    return array;
}

//Функция вывода массива в формате [a1, a2,a3, ..., ai]
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }

    Console.WriteLine($"");
}
//Функция подсчета элементов на нечетных позициях
int CountOddindexes(int[] array)
{
    int fullSummary = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            fullSummary = fullSummary + array[i];
        }
    }

    return fullSummary;
}
//Функция подсчета элементов на четных позициях
int CountEvenIndexes(int[] array)
{
    int fullSummary = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            fullSummary = fullSummary + array[i];
        }
    }

    return fullSummary;
}

//Чтение данных из консоли
Console.Write("Введите количество элементов для генерации массива: ");
int usrCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний интервал случайных чисел: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний интервал случайных чисел: ");
int end = Convert.ToInt32(Console.ReadLine());

//Инициализация массива
int[] userArray = GenerateArray(usrCount, start, end);
//Распечатка массива
PrintArray(userArray);
//Вызов метода
Console.WriteLine($"Сумма элементов на нечетных позициях: {CountOddindexes(userArray)}");
//Вызов метода
Console.WriteLine($"Сумма элементов на четных позициях: {CountEvenIndexes(userArray)}");