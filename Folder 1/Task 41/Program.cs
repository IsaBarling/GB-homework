// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] newArray = new int[0];

SetArray(ref newArray);
Console.WriteLine($"[{String.Join(",", newArray)}] -> {CheckNumber(newArray)}");


int CheckNumber(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i > 0)
        {
            count++;
        }
    }
    return count;
}

string ReadFromConsole()
{
    string resultOutput = string.Empty;
    while (true)
    {
        var pressedButton = Console.ReadKey(true);
        switch (pressedButton.Key)
        {
            case ConsoleKey.Backspace:
                if (resultOutput.Length > 0)
                {
                    resultOutput = resultOutput.Remove(startIndex: resultOutput.Length - 1, count: 1);
                    Console.Write(value: $"{pressedButton.KeyChar} {pressedButton.KeyChar}");
                }
                break;
            case ConsoleKey.Enter:
                Console.WriteLine();
                return resultOutput;
            case ConsoleKey.Escape:
                resultOutput = "out";
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(value: "Нажали Esc, цикла ввода завершен ");
                return resultOutput;
            default:
                if (char.IsDigit(c: pressedButton.KeyChar) || (pressedButton.KeyChar == '-' && resultOutput.Length == 0))
                {
                    Console.Write(value: pressedButton.KeyChar);
                    resultOutput += pressedButton.KeyChar;
                }
                break;
        }
    }
}

void SetArray(ref int[] array)
{
    while (true)
    {
        Console.WriteLine($"Введите число №{array.Length + 1} (Для завершения цикла ввода нажмите Esc):");
        try
        {
            string data = ReadFromConsole();
            if (data == "out")
            {
                break;
            }
            int number = Convert.ToInt32(data);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = number;
        }
        catch
        {
            Console.WriteLine("Ошибка преобразования числа");
        }
    }
}
