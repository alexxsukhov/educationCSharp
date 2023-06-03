/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */
 
//Генерация двумерного массива
int[,] GenerateMatrix(int rows = 4, int cols = 4, int start = 1, int end = 10)
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


void SortMatrixRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x + 1])
                {
                    (array[i, x], array[i, x + 1]) = (array[i, x + 1], array[i, x]);
                }
            }
        }
    }
}

int[,] userMatrix = GenerateMatrix();

PrintMatrix(userMatrix);
SortMatrixRows(userMatrix);
Console.WriteLine();
PrintMatrix(userMatrix);