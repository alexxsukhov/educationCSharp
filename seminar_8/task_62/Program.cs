/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */




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

void FillArraySpiral(int[,] array)
{
    int value = 1;
    int startRow = 0;
    int endRow = array.GetLength(0) - 1;
    int startCol = 0;
    int endCol = array.GetLength(0) - 1;

    while (startRow <= endRow && startCol <= endCol)
    {
        // Верхняя строка
        for (int i = startCol; i <= endCol; i++)
        {
            array[startRow, i] = value++;
        }

        startRow++;

        // Правый столбец
        for (int i = startRow; i <= endRow; i++)
        {
            array[i, endCol] = value++;
        }

        endCol--;

        // Нижняя строка
        for (int i = endCol; i >= startCol; i--)
        {
            array[endRow, i] = value++;
        }

        endRow--;

        // Левый столбец
        for (int i = endRow; i >= startRow; i--)
        {
            array[i, startCol] = value++;
        }

        startCol++;

    }
}




//Чтение данных из консоли
Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] userMatrix = new int[rows,cols];
PrintMatrix(userMatrix);
FillArraySpiral(userMatrix);
Console.WriteLine();
PrintMatrix(userMatrix);