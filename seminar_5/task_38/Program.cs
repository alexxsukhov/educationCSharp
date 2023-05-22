/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


//генерация массива
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
int DifferenceMinMax(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    return max - min;
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
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DifferenceMinMax(userArray)}");
