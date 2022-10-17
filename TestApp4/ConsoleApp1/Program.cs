using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using andestech.learning2022.krasn.library;

namespace andestech.learning2022.krasn
{
    internal class Singleton { 
     // private static Singleton[] _instance = new Singleton[3];
     // private int counter;
        private static Singleton _instance;
              
      public static Singleton Instance {
            get
            {
                if (_instance == null) _instance = new Singleton();
                return _instance;
            }
                        }

        private Singleton()
        {
            WriteLine("+++ Singleton: " + GetHashCode());
         
        }
    
    }

   


    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Book book1 = new Book(author: "Jack London", title: "White silence");
            WriteLine(book1);
            book1.Loan();

            RareBook book2 = new RareBook(author: "Leonaro da Vinci", title: "Opus 1112", "AA-dd-44-2022");
            WriteLine(book2);
            book2.Loan();

            //new Singleton(); private constructor!!!


        }
    }
}
