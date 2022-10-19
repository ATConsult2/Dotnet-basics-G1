﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{

    internal class GenContainer<TT>
    {
        public TT Data { get; set; }

        public GenContainer() { }
        public GenContainer(TT t){
            Data = t;
         }
        
    }

    internal class Program
    {
        static void OperatorIndexerTest() {
            Box box1 = new Box { Data = 10 };
            Box box2 = new Box { Data = 20 };
            Box box3 = box1 + box2; // operator +!!
            WriteLine("box3.Data=" + box3.Data);
            Box box4 = ++box3 + box3++;     // operator ++!!
            WriteLine("box3.Data=" + box3.Data);
            WriteLine("box4.Data=" + box4.Data);

            Container ctx = new Container(
              new Box[] { box1, box2, box3 }
              );
            WriteLine(ctx[1].Data);  // indexer!!!
        }

        static void Main(string[] args)
        {
            // OperatorIndexerTest();
            GenContainer<int> container = 
                new GenContainer<int> { Data = 77 };

            GenContainer<Box> container2 =
                           new GenContainer<Box> { Data = new Box {Data=11 } };

            GenContainer container3 =
                          new GenContainer(new Box { Data = 11 });


        }
    }
}
