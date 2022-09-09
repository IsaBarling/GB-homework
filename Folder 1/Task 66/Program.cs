using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");

            int temp = m;

            if (m > n)
            {
                m = n;
                n = temp;
            }
            
            PrintSumm2(m, n);
            Console.ReadLine();
        }
        
        static void PrintSumm2(int m, int n)
        {
            int sum = 0;
            for(int i = m + 1; i < n; i++)
            {
                if (i % 2 == 0)
                    sum += i;

            }
            Console.Write("Sum is " + sum);

        }

        public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    }
}
