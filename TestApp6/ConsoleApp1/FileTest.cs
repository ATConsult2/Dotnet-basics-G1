using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class FileTest
    {
        static void Main(string[] args)
        {
         // DirectoryInfo
         // FileInfo

         File.WriteAllText(@"textfile.txt", "BLABLA - 222\nCCC\nBBBB",
                Encoding.UTF8);
        
         string[] datas = File.ReadAllLines(@"textfile.txt", Encoding.UTF8);
            foreach (var s in datas) WriteLine(s);

            using (FileStream fs = new FileStream("file2.bin", FileMode.Append))
            {
                string data = "Hi!\nHello!";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                fs.Seek(0, SeekOrigin.End);
                fs.Write(buffer, 0, buffer.Length);
            
            }

            using (BinaryWriter bw = new BinaryWriter(
                new FileStream("file3.bin", FileMode.OpenOrCreate)
                )) {
                bw.Write(12345678123L);
                bw.Write(1.234f);
                bw.Write(12);

            }

        }

    }
}
