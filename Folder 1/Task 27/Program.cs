//*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int SumOfNumbers(int number)
{
    int totalNum = 0;
    while(num > 0) 
	{
        totalNum = totalNum + num % 10;
        num = num / 10;
    }
    return totalNum;
}

Console.WriteLine($"Сумма чисел в числе: {SumOfNumbers(num)}");
