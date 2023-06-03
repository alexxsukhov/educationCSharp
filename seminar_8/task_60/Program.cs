/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */





//Генерация одномерного массива уникальными числами в заданном диапазоне
int[] GenerateUniqArrayInRange(int lengthArray = 20, int start = 10, int end = 100)
{
    int[] tempUniqArray = new int[lengthArray];

    for (int i = 0; i < tempUniqArray.GetLength(0); i++)
    {
        tempUniqArray[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (tempUniqArray[i] == tempUniqArray[j])
            {
                tempUniqArray[i] = new Random().Next(start, end);
                j = 0;
            }
        }
    }

    return tempUniqArray;
}

//Генерация трехмерного массива по уникальтным значениям из одномерного массива
int[,,] Generate3DArray(int rows = 2, int cols = 2, int colsRows = 2, int start = 10, int end = 100)
{
    int[,,] array = new int[rows, cols, colsRows];

    // Генерируем случайные уникальные числа во временный одномерный массив размером x * y * x трехмерного массива
    int[] tempUniqArray =
        GenerateUniqArrayInRange(array.GetLength(0) * array.GetLength(1) * array.GetLength(2), start, end);

    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = tempUniqArray[count];
                count++;
            }
        }
    }

    return array;
}


//Вывод трехмерного массива на печать
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($" {array[i, j, k]} [{i}, {j}, {k}]");
            }

            Console.WriteLine();
        }
    }
}


//Чтение данных из консоли
Console.Write("Введите количество x для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество y для генерации массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество z для генерации массива: ");
int colsRows = Convert.ToInt32(Console.ReadLine());

if (rows * cols * colsRows < 100)
{
    int[,,] user3DArray = Generate3DArray(rows, cols, colsRows);
    Print3DArray(user3DArray);
}
else
{
    Console.WriteLine("Невозможно сгенерировать массив уникальных значений для данного количество элементов");
}

