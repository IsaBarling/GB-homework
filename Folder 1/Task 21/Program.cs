// Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
//ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A: ");
double dotAx = Convert.ToDouble(Console.ReadLine());
double dotAy = Convert.ToDouble(Console.ReadLine());
double dotAz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double dotBx = Convert.ToDouble(Console.ReadLine());
double dotBy = Convert.ToDouble(Console.ReadLine());
double dotBz = Convert.ToDouble(Console.ReadLine());

double dotC = Math.Sqrt(Math.Pow((dotAx) - (dotBx), 2) + Math.Pow((dotAy) - (dotBy), 2) + Math.Pow((dotAz) - (dotBz), 2));
Console.WriteLine(Math.Round(dotC, 2));
