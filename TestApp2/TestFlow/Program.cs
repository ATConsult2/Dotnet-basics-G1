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
        static void Main(string[] args)
        {
            WriteLine(byte.MaxValue);
            WriteLine(short.MaxValue);
            WriteLine(int.MaxValue);
            WriteLine(long.MaxValue);
            WriteLine(ulong.MaxValue);

            for (;;)
            {
                byte b1;
                Write("Enter number: ");
                string data = ReadLine();
                if (data == "x") break;
                // byte b2 = byte.Parse(data);
                byte b2;
                if (!byte.TryParse(data, out b2))
                {
                    b2 = 0;
                    WriteLine("Wrong value. Try again..");
                }
                b1 = (byte)(100 + b2);
                WriteLine($"result: {b1}");
                //if (b1 == 100) break;
            }


        }
    }
}
