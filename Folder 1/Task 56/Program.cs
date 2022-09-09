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
PrintArrayMin(array: valueArray,
           minValue: MinIndexSumRowArray(valueArray),
               note: $"Рандомный от {minValueArray} до {maxValueArray}");

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

int MinIndexSumRowArray(int[,] array)
{
    int minSum = int.MaxValue;
    int sum;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            result = i;
        }
    }
    return result;
}

void PrintArrayMin(int[,] array, int minValue, string note = "")
{
    const int tabColumns = 6;
    Console.WriteLine($"Массив {array.GetLength(0)}х{array.GetLength(1)}:     {note}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],tabColumns}");
        }
        if (i == minValue)
        {
            Console.Write(" -> Наименьшая сумма в строке");
        }
        Console.WriteLine();
    }
}