/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
 */


//генерация массива

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

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
}

int[] ChangeArrayToOneRow(int[,] array)
{
    List<int> arrayI = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayI.Add(array[i, j]);
        }
    }

    return arrayI.ToArray();
}

int[] DelDublicateElementsArray(int[] array)
{
    List<int> arrayTemp = new List<int>();

    foreach (int item in array)
    {
        if (!arrayTemp.Contains(item))
        {
            arrayTemp.Add(item);
        }
    }

    int[] arrayNew = arrayTemp.ToArray();
    return arrayNew;
}

void CountElements(int[] arrayUnic, int[] array)
{
    int countElement = 0;
    foreach (var el in arrayUnic)
    {
        foreach (var item in array)
        {
            if (el == item)
            {
                countElement += 1;
            }
        }

        Console.WriteLine($"Элемент {el} встречается {countElement} раз");
        countElement = 0;
    }
}

//Чтение данных из консоли
Console.Write("Введите количество строк для генерации массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для генерации массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] userArray = GenerateMatrix(rows, cols);
PrintMatrix(userArray);
int[] arrayOneLine = ChangeArrayToOneRow(userArray);

int[] arrayUnic = DelDublicateElementsArray(arrayOneLine);
Console.WriteLine();
PrintArray(arrayOneLine);
CountElements(arrayUnic, arrayOneLine);