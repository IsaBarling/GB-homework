Console.Write($"Введите количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumOfElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 0 && i != 0)
      {
        sumOfElements = sumOfElements + randomNumbers[i];
      }
    }
  return sumOfElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 99);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");
