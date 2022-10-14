using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.rocketplant
{
    class Rocket
    {
        public string Name;
        public double Mass;
        public double Power;
        //.....
        public Rocket() {
            WriteLine("+++ ctor of Rocket");
        }

        private long generateId() {
            return new Random().Next(1_000_000_000);
        }

        public string getInfo() {
            return $"Rocket {Name} with power: {Power}, start mass: {Mass}.";
        
        }

    }
}
