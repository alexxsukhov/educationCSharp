/*
 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

//Функция подсчета четных элементов
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }

    return count;
}

//Функция подсчета чнеетных элементов
int CountOddNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            count = count + 1;
        }
    }

    return count;
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
Console.WriteLine($"Четных элементов: {CountEvenNumbers(userArray)}");
//Вызов метода
Console.WriteLine($"Нечетных элементов: {CountOddNumbers(userArray)}");