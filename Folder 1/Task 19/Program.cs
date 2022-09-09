// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

int temp = nNumber;
int rev = 0;

if (nNumber > 2)
{

    while (nNumber > 0)
    {
        int dig = nNumber % 10;
        rev = rev * 10 + dig;
        nNumber = nNumber / 10;
    }
    if (temp == rev)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
}
else
{
    Console.WriteLine("Ваше число не пятизначное!");
}
