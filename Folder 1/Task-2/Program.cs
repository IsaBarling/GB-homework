/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int user_number_first = new int();
int user_number_second = new int();

Console.Write("Введите первое число ");
user_number_first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
user_number_second = Convert.ToInt32(Console.ReadLine());

if (user_number_first < user_number_second)
{
    Console.WriteLine("Максимальное число = " + user_number_second + ", Минимальное число = " + user_number_first);
}
else
{
    Console.WriteLine("Максимальное число = " + user_number_first + ", Минимальное число = " + user_number_second);
}
