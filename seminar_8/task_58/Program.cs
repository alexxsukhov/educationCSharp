/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */

//Генерация двумерного массива

int[,] GenerateMatrix(int rows = 2, int cols = 2, int start = 1, int end = 3)
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

void MultiplyMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] resultMatrix = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
    if (FirstMatrix.GetLength(0) != SecondMatrix.GetLength(1))
    {
        Console.WriteLine("Невозможно выполнить перемножение матриц!");
    }
    else
    {
        for (int i = 0; i < FirstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < SecondMatrix.GetLength(1); j++)
            {
                int multyElements = 0;
                for (int k = 0; k < FirstMatrix.GetLength(1); k++)
                {
                    multyElements += FirstMatrix[i, k] * SecondMatrix[k, j];
                    resultMatrix[i, j] = multyElements;
                }
            }
        }
        Console.WriteLine("Результирующая матрица");
        PrintMatrix(resultMatrix);
    }

    
}

//Чтение данных из консоли
Console.Write("Введите количество строк для генерации 1-ого массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации 1-ого массива: ");
int colsFirstMatrix = Convert.ToInt32(Console.ReadLine());


//Чтение данных из консоли
Console.Write("Введите количество строк для генерации 2-ого массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации 2-ого массива: ");
int colsSecondMatrix = Convert.ToInt32(Console.ReadLine());


int[,] userMatrix1 = GenerateMatrix(rowsFirstMatrix, colsFirstMatrix);
int[,] userMatrix2 = GenerateMatrix(rowsSecondMatrix, colsSecondMatrix);

Console.WriteLine("Первая матрица");
PrintMatrix(userMatrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintMatrix(userMatrix2);
Console.WriteLine();


MultiplyMatrix(userMatrix1, userMatrix2);