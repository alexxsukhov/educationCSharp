/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */


//Генерация двумерного массива
int[,] GenerateMatrix(int rows = 4, int cols = 4, int start = 0, int end = 10)
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
 
//Вывод двумерного массива на печать
void PrintMatrix(int[,] array)
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


void FindMinimalSummaryRow(int[,] array)
{
    int rowSummary = 0;
    int numberLine = 0;
    int minimalSummary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSummary += array[i, j];
            if (i == 0)
            {
                minimalSummary = rowSummary;
            }
        }

        if (minimalSummary > rowSummary)
        {
            minimalSummary = rowSummary;
            numberLine = i;
        }
        rowSummary = 0;
    }
    Console.WriteLine($"Строка с минимальной суммой элементов {numberLine} - сумма элементов {minimalSummary}");
}

int[,] userMatrix = GenerateMatrix();

PrintMatrix(userMatrix);
Console.WriteLine();
FindMinimalSummaryRow(userMatrix);
