/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int user_number_first = new int();
int user_number_second = new int();
int user_number_third = new int();

Console.Write("Введите первое число ");
user_number_first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
user_number_second = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
user_number_third = Convert.ToInt32(Console.ReadLine());

if (user_number_first < user_number_third)
{
    Console.WriteLine("Максимальное число " + user_number_third);
}

else if (user_number_first < user_number_second)
{
    Console.WriteLine("Максимальное число " + user_number_second);
}

else
{
    Console.WriteLine("Максимальное число " + user_number_first);
}
