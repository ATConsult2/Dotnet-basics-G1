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

        static void TestDelegate2(Action<int> del, int i)
        {
            //.......
            del(i);
        }

        static void Main(string[] args)
        {
            TestDelegate1(F1, 10);
            TestDelegate1(F2, 20);
            TestDelegate2(F1, 10);
            TestDelegate2(F2, 20);

            WriteLine("------------------------------");
            Action<int> d1 = F1;
            d1 += F2;
            TestDelegate2(d1, 20);
            d1 -= F1;
            WriteLine("------------------------------");
            TestDelegate2(d1, 20);
            TestDelegate2(i =>
            {
                WriteLine($"Lambda test 1 --> {i}");
            },11);

            Action<int> L2 = 
                i => WriteLine($"Lambda test 2 --> {i}");
            d1 += L2;
            TestDelegate2(d1, -12);

            WriteLine("---------- Dictionary lambda test ------------");
            Dictionary<string, Func<double, double, double>> calculus =
                new Dictionary<string, Func<double, double, double>>()
                {
                    {"+", (x,y) => x+y },
                    {"-", (x,y) => x-y },
                    {"*", (x,y) => x*y },
                    {"/", (x,y) => x/y }
                };

            WriteLine(calculus["/"](1,5));
        }
    }
}
