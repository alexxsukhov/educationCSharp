/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координату x для первой точки: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y для первой точки: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z для первой точки: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x для второй точки: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y для второй точки: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z для второй точки: ");
double bz = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));

Console.WriteLine($"Расстояние между точками в трехмерном пространстве: {distance}");