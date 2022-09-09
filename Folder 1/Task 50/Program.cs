// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// (на вход именно поступает позиция элемента, можете разбить на две переменные или прописать
//  в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)  

const int minValueArray = 0;
const int maxValueArray = 9;
const int rowsArray = 6;
const int columnsArray = 5;

try
{
    Console.WriteLine();
    int[,] valueArray = GetArray(rows: rowsArray,
                              columns: columnsArray,
                             minValue: minValueArray,
                             maxValue: maxValueArray);

    PrintArray(valueArray);
    Console.WriteLine();

        Console.Write("Введите номер столбца элемента двумерного массива (нумерация с 0): ");
    int viewColumns = Convert.ToInt32(ReadFromConsole());
        Console.Write("Введите номер строки элемента двумерного массива (нумерация с 0): ");
    int viewRows = Convert.ToInt32(ReadFromConsole());

    Console.WriteLine(ViewElementArray(array: valueArray,
                                        rows: viewRows,
                                     columns: viewColumns));
}
catch
{
    Console.WriteLine("Ошибка ввода");
}


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    const int tabColumns = 4;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],tabColumns}");
        }
        Console.WriteLine();
    }
}

string ViewElementArray(int[,] array, int rows, int columns)
{
    string result = $"Элемент с индексом [{rows},{columns}], в массиве не найдено";
    if (rows < array.GetLength(0))
    {
        if (columns < array.GetLength(1))
        {
            result = $"Значение элемента с индексом [{rows},{columns}] = {array[rows, columns]}";
        }
    }
    return result;
}

string ReadFromConsole()
{
    string result = string.Empty;
    while (true)
    {
        var pressedButton = Console.ReadKey(true);
        switch (pressedButton.Key)
        {
            case ConsoleKey.Backspace:
                if (result.Length > 0)
                {
                    result = result.Remove(startIndex: result.Length - 1, count: 1);
                    Console.Write(value: $"{pressedButton.KeyChar} {pressedButton.KeyChar}");
                }
                break;
            case ConsoleKey.Enter:
                Console.WriteLine();
                return result;
            default:
                if (char.IsDigit(c: pressedButton.KeyChar))
                {
                    Console.Write(value: pressedButton.KeyChar);
                    result += pressedButton.KeyChar;
                }
                break;
        }
    }
}
