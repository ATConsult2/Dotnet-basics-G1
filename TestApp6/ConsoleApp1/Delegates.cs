using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{
    public delegate void TestData(int data);
    internal class Delegates
    {
        static void F1(int i)
        {
            WriteLine($"F1 --> {i}");
        }

        static void F2(int i)
        {
            WriteLine($"F2 --> {i}");
        }

        static void TestDelegate1(TestData del, int i) {
            //.......
            del(i);
        }

        static void Main(string[] args)
        {
            TestDelegate1(F1, 10);
            TestDelegate1(F2, 20);


        }
    }
}
