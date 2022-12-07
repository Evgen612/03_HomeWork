// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки a1: ");
int a1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки a2: ");
int a2 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки a3: ");
int a3 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки b2: ");
int b2 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки b3: ");
int b3 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((a1 - b1 )*(a1 - b1 ) + (a2 - b2 )*(a2 - b2) +(a3 - b3)*(a3 - b3));
Console.Write(result);
