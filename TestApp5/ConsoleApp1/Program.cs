using System;
using System.Collections.Generic;
using System.Collections;
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

        /*  static T Sum<T>(params T[] datas) //where T:INumber
           {
               T s = default(T);
               foreach(var d in datas) s = s + d;
               return s;
           }*/

        static double Sum<T>(params T[] datas)// where T: IAddable 
        {
            if (typeof(T) == typeof(Box)) {//
            }

            double[] arr = datas.Cast<double>().ToArray(); 
            double s = 0; ;
            foreach (var d in arr) s = s+ d;
            return s;
        }


        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        static void Swap(ref object a, ref object b)
        {
           // if (a is Box bb) { }
            object c = a;
            a = b;
            b = c;
        }

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

        static void PrintCollection(IEnumerable collection)
        {
            Write("{");
            foreach (var v in collection) Write(v + ", ");
            Write("\b\b}\n");
        }

        static void PrintCollection(IDictionary collection)
        {
            Write("{");
            foreach (var key in collection.Keys) Write($"({key}->{collection[key]}), ");
            Write("\b\b}\n");
        }

        static void Main(string[] args) {

            Stack<String> stack =  new Stack<String>();
            stack.Push("AA");
            stack.Push("BB");
            stack.Push("CC");
            PrintCollection(stack);
            stack.Pop();
            PrintCollection(stack);

            //-------------------------
            Queue<int> queue = new Queue<int>(10);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            PrintCollection(queue);
            queue.Dequeue();
            PrintCollection(queue);
            //---------------------------

            Dictionary<int, Box> dict = new Dictionary<int, Box>()
            {
               {1, new Box(310) },
               {4, new Box(-30) },
               {2, new Box(0) },
               {7, new Box(330) }, {10, new Box(99) }

            };
            dict.Add(40, new Box(100));
            PrintCollection(dict);


        }

        static void Main3(string[] args) {

            // ---- Collections ---- 
            ArrayList alist = new ArrayList { 1, -20, 3, 4, 5, "qqq", new Box { Data = 1 } };
            PrintCollection(alist);

            ArrayList alist2 = new ArrayList { 1, -20, 3, 4, 5, 10, -22, 5, 77, 91 };
            PrintCollection(alist2);
            alist2.Insert(2, 7);
            PrintCollection(alist2);
            alist2.Sort();
            PrintCollection(alist2);
            WriteLine(alist2.Capacity);
            WriteLine(alist2.Count); WriteLine("-------------");
            alist2.InsertRange(5, new ArrayList() { -1, -2, -3, -4, -5, -6 });
            WriteLine(alist2.Capacity);
            WriteLine(alist2.Count);

            // Linq
            var res = from int d in alist2
                      where d > 0
                      orderby d descending
                      select d;
            PrintCollection(res);

            SortedList slist = new SortedList() {
             {1, "Hi!" },
             {2, "Hello!" },
             {-4, "Howdoyoudo!"},
             {-2, "Salute!!" }
         };

            PrintCollection(slist);

            // ---- Generic Collection 
            List<Box> boxes = new List<Box>() {
         new Box(1),
         new Box(2),
         new Box(-10),
         new Box(4)
             };
            PrintCollection(boxes);

            var boxes2 = from box in boxes
                         orderby box.Data
                         select box;
            Box[] barr = (from box in boxes orderby box.Data select box).ToArray<Box>();
            
            PrintCollection(barr);
            Array.Sort(barr, MyCompare);
            Array.Sort(barr, (Box a, Box b) => b.Data - a.Data);
            //Array.Sort(barr);
            PrintCollection(barr);

        }

        static int MyCompare(Box a, Box b) {
            return a.Data - b.Data;
        }

        static void Main2(string[] args)
        {
            // OperatorIndexerTest();
            GenContainer<int> container = 
                new GenContainer<int> { Data = 77 };

            GenContainer<Box> container2 =
                           new GenContainer<Box> { Data = new Box {Data=11 } };

            GenContainer<Box> container3 =
                          new GenContainer<Box>(new Box { Data = 11 });
            Box box1 = new Box { Data = 1 };
            Box box2 = new Box { Data = 2 };

            WriteLine($"{box1.GetHashCode()} -- {box2.GetHashCode()}");
            WriteLine($"{box1.Data} -- {box2.Data}");

            Swap<Box>(ref box1, ref box2);
        

            WriteLine($"{box1.GetHashCode()} -- {box2.GetHashCode()}");
            WriteLine($"{box1.Data} -- {box2.Data}");

        }
    }
}
