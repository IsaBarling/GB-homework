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
SortArray(ref valueArray);
PrintArray(valueArray);

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

void SortArray(ref int[,] array)
{
    int max;
    int tempValue;
    int iMax;
    int jMax;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            max = array[i, k];
            iMax = i;
            jMax = k;
            for (int j = k; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    iMax = i;
                    jMax = j;
                }
            }
            tempValue = array[i, k];
            array[i, k] = array[iMax, jMax];
            array[iMax, jMax] = tempValue;
        }
    }
}
