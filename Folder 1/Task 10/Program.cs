﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трёхзначное число: ");
string stringNumber = Console.ReadLine();
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
