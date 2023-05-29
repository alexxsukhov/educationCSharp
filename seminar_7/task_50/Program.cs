/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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


string FindElementForIndexes(int[,] array, int findNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNumber)
            {
                return $"Позиция искомого числа: [{i}, {j}]";
            }

        }
    }

    return $"Данного числа нет!";
}


//Чтение данных из консоли
Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());


int[,] userArray = GenerateArray(rows, cols);

PrintArray(userArray);

Console.WriteLine(FindElementForIndexes(userArray, findNumber));