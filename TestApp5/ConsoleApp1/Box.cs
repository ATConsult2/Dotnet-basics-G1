using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal class Box : IComparable<Box>

    {
        public Box() { }
        public Box(int data) {

            Data = data;
        }
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

        public override string ToString()
        {
            return $"Box:{Data}->{GetHashCode()}";
        }


        public static Box Plus(Box a, Box b)
        {
            //.....
            return new Box { Data = a.Data + b.Data };

        }

        public int CompareTo(Box obj)
        {
            return Data - obj.Data;
        }
    }
}
