using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.rocketplant
{
    class Rocket2
    {
        private string _name;
        private double _mass;
        private double _power;    

        public string Name
        {
            get { 
                //....
                return _name; }
            set { 
                //....
                _name = value; }  
        }

        public double Mass {
            get { return _mass; }
            set { _mass = value; }  
        }

        public double Power {
            get { return _power; }
            set { _power = value; } 
        }
        //.....
        public Rocket2() {
            WriteLine("+++ ctor of Rocket2");
        }

        private long generateId() {
            return new Random().Next(1_000_000_000);
        }

        public string getInfo() {
            return $"Rocket {Name} with power: {Power}, start mass: {Mass}.";
        
        }

    }
}
