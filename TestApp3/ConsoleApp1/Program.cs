using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {

        static int Summa(params int[] numbers)
        {
            int summa = 0;
            for (int i = 0; i < numbers.Length; i++)
            { 
            summa += numbers[i];    
            }
            return summa;
        }

        static int Summa3(int[] numbers)
        {
            int summa = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                summa += numbers[i];
            }
            return summa;
        }


        static int Summa2(params int[] numbers)
        {
            int summa = 0;
            foreach (int number in numbers) summa += number;
            
            return summa;
        }

        static void Main(string[] args)
        {
            // 1-D arrays
            byte[] arr = new byte[10];
            byte[] arr2 = new byte[] {1,22,55,4,126,55,66};

            Write("[");
            for (int i = 0; i < arr2.Length; i++)
            {
                Write(arr2[i] + ", ");
            }
            Write("\b\b]\n");
            //------------------------------------------
            // заполняем массив случ байтами
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (byte)r.Next(255);
            }
            //new Random().NextBytes(arr);
            foreach (int element in arr) Write(element + ", ");
            Write("\b\b]\n");
            // summa test 
            WriteLine(Summa(1, 2, 3, 4, 5, 6, 7, 8, 9));
            WriteLine(Summa2(1, 2, 3, 4, 5, 6, 7, 8, 9));

            WriteLine(Summa(new int[] {1,2,3,4,5,6,7,8,9}));
            // WriteLine(Summa(arr2));
            // test command line args
            Write("Command line args: ");
            foreach (string arg in args) Write(arg + ", ");
            WriteLine("\b\b.");

            Write("Press any key...");
            ReadKey();
        }
    }
}
