
using static System.Console;
using andestech.learning2022.krasn.utils;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Greets() {
            Write("Enter your name: ");
            string name = ReadLine();
            WriteLine($"Hello, {name}!");
           // WriteLine(string.Format("Hello, {0}!!!", name));

        }
        static void Main(string[] args)
        {
            int delta = 12;
            // Greets test!
            WriteLine("Salute!");

            Greets();
            utils.Greets.Hello();
            Greets2.Hello();
            WriteLine("Hi!");
        }
    }
}
