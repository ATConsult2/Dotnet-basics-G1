using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal class Box
    {
        public int Data { get; set; }
        //....
        public static Box operator +(Box a, Box b)
        {
            //.....
            return new Box { Data = a.Data + b.Data };
        
        }

        public static Box operator ++(Box b)
        {
            //.....
            b.Data++;
            return b;
        }

        public static Box operator --(Box b)
        {
            //.....
            b.Data--;
            return b;
        }



        public static Box Plus(Box a, Box b)
        {
            //.....
            return new Box { Data = a.Data + b.Data };

        }
    }
}
