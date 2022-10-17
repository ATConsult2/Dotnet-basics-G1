using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.game
{
    internal interface IMovable
    {
        void MoveLeft();
        void MoveRight();

        void Rotate(double degrees);
        ///

    }

    class MoveTesris1 : IMovable
    {
        public void MoveLeft()
        {
            Write(" <- ");
        }

        public void MoveRight()
        {
            Write(" -> ");
        }

        public void Rotate(double degrees)
        {
            Write(" <> ");
        }
    }

}
