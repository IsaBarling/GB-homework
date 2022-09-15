namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Этап 1 Создание первичного массива для выборки
             */
            string[] array = GetUserArray();
            
            /*
             * Этап 2 Выборка тех строк, где меньше четырех символов.
             */
            string[] output = new string[0];

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i].Length < 4)
                {
                    output = AddElementToArray(output, array[i]);
                }
            }
            
            /*
             * Этап 3 Вывод результатов.
             */
             
             if (output.Length > 0)
             {
                Console.WriteLine(String.Join( ";", output));
             }
            else 
            {
                Console.WriteLine("Подходящее значение не найдено");
            }
        }

        private static string[] AddElementToArray(string[] input, string v)
        {
            string[] value = new string[input.Length + 1];
            for(int i = 0; i < input.Length; i++)
            {
                value[i] = input[i];
            }
            value[value.Length - 1] = v;
            return value;
        }
        

        private static string[] GetUserArray()
        {
            Console.WriteLine("Введите элементы первого массива через запятую. Для завершения ввода нажмите Enter");
            return Console.ReadLine().Split(',');
        }
    }
}