// Убрать дубликаты в массиве


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

//Чтение данных из консоли
Console.Write("Введите количество элементов для генерации массива: ");
int usrCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний интервал случайных чисел: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний интервал случайных чисел: ");
int end = Convert.ToInt32(Console.ReadLine());

//Инициализация массива
int[] userArray = GenerateArray(usrCount, start, end);

//Array.Sort(userArray);


int[] DelDublicateArray(int[] array)
{
    List<int> arrayTemp = new List<int>();

    foreach (int t in array)
    {
        if (!arrayTemp.Contains(t))
        {
            arrayTemp.Add(t);
        }
    }

    int[] arrayNew = arrayTemp.ToArray();
    //Array.Sort(arrayNew);
    return arrayNew;
}


PrintArray(userArray);
PrintArray(DelDublicateArray(userArray));