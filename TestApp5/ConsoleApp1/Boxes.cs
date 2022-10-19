using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal class Container
    {
        int _size;
        public Box[] Boxes{ get; private set; }

       /* public Box this[int i] { 
        set { Boxes[i] = value; }
        get { return Boxes[i]; }    
               }*/
        
        public Box this[int i]
        {
            set => Boxes[i] = value; 
            get => Boxes[i];
        }
        public Container(int size)
        {
            _size = size;
            Boxes = new Box[size];

        }

        public Container(Box[] boxes)
        {
            _size = boxes.Length;
            Boxes = boxes;
        }

    }
}
