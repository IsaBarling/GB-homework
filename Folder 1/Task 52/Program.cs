// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// (Решение очень похоже на задачу 50, первые три блока оставила как и в прошлом задании)

const int minValueArray = 0;
const int maxValueArray = 9;
const int rowsArray = 6;
const int columnsArray = 5;

    Console.WriteLine();
    int[,] valueArray = GetArray(rows: rowsArray,
                              columns: columnsArray,
                             minValue: minValueArray,
                             maxValue: maxValueArray);

PrintArray(valueArray);
Console.WriteLine();
PrintAvgArray(valueArray);

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
    const int tabColumns = 6;
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

void PrintAvgArray(int[,] array)
{
    const int tabColumns = 6;
    double averageSumColumns = 0;
    int countRows = 0;
    Console.WriteLine("Среднеарифметическое элементов в каждом столбце:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        countRows = 0;
        averageSumColumns = 0;
        while (countRows < array.GetLength(0))
        {
            averageSumColumns += array[countRows, i];
            countRows++;
        }
        Console.Write($"{Math.Round(averageSumColumns / countRows, 1),tabColumns}");
    }
}
