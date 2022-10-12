using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    enum FileFlags { 
    Read, Write, Append, Create, ReadWrite
    }

    internal class Program
    {

        static void accessFile(FileFlags ff, string fileName = "file1")
        {
            switch (ff)
            {
                case FileFlags.Create:
                    WriteLine($"Create file {fileName}. ");
                    //...
                    break;
                case FileFlags.Write:
                    WriteLine($"Write to file {fileName}. ");
                    //...
                    break;
                case FileFlags.Read:
                    WriteLine($"Read from file {fileName}. ");
                    //...
                    break;
                default:
                    WriteLine("some ops...");
                    break;
            }
        
        
        }

        static void checkNumbers() {
            WriteLine("Simple calc, press \"x\" to exit");

            for (; ; )
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
                //b1 = checked((byte)(100 + b2));
                checked
                {
                    b1 = (byte)(100 + b2);
                }
                WriteLine($"result: {b1}");
                //if (b1 == 100) break;
            }

        }

        static void getMaxNumbers() {
            WriteLine(byte.MaxValue);
            WriteLine(short.MaxValue);
            WriteLine(int.MaxValue);
            WriteLine(long.MaxValue);
            WriteLine(ulong.MaxValue);
        }

        static void testFileOps() {
            accessFile(FileFlags.Create, "file1.txt");
            accessFile(FileFlags.Write);
            accessFile(FileFlags.ReadWrite, "file1.txt");

        }

        static void testIf(int a) {
            if (a > 10)
            {
                WriteLine("a>10");
            }
            else if (a > 2) { WriteLine("10>=a>2"); }
            else if (a > -3) { WriteLine("2>=a>-3"); }
            else { WriteLine("-3>=a"); }


            WriteLine(
                $"Program has {a} bug{((a==1)?"":"s")}!");
         
        }
        static void Main(string[] args)
        {
            //getMaxNumbers();    
            //checkNumbers();
            testFileOps();
            testIf(1);








        }
    }
}
