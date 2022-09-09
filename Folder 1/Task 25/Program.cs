//*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());

int getRate(int firstNum, int secondNum)
{
    int totalNum = firstNum;
    for(int i = 1; i < secondNum; i++) 
    {
        totalNum *= firstNum;
    }
    return totalNum;
}

Console.WriteLine($"Результат = {getRate(firstNum, secondNum)}");
