using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Singleton { 
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


        }
    }
}
