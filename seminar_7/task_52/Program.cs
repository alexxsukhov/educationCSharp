/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */
 
//генерация массива

int[,] GenerateArray(int rows = 3, int cols = 4, int start = 0, int end = 10)
{
    int[,] array = new int[rows, cols];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(start, end);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

void Average(int[,] array)
{
    double avg = 0;
    double summaryElementCol = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summaryElementCol = summaryElementCol + array[i, j];
        }

        avg = summaryElementCol / array.GetLength(1);
        
        Console.WriteLine($"Среднее арифметическое столбца {j}: {avg}");
    }
}

//Чтение данных из консоли
Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] userArray = GenerateArray(rows, cols);

PrintArray(userArray);

Average(userArray);
 