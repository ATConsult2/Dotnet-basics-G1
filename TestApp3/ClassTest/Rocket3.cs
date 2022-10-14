using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.rocketplant
{
    class Rocket3
    {
        private string _name;
        private double _mass;
        private double _power;    

        public string Name
        {
            get { 
                //....
                return _name; }
            private set { 
                //....
                _name = value; }  
        }

        public double Mass {
            get { return _mass; }
            private set { _mass = value; }  
        }

        public double Power {
            get { return _power; }
            private set { _power = value; } 
        }
        //.....
        public Rocket3() {
            WriteLine("+++ ctor of Rocket2");
        }

        //public Rocket3(string name, double mass, double power)
        //{
        //    Name = name;
        //    Mass = mass;
        //    Power = power;

        //}

        public Rocket3(string Name, double Power, double Mass)
        {
            this.Name = Name;
            this.Mass = Mass;
            this.Power = Power;

        }

        private long generateId() {
            return new Random().Next(1_000_000_000);
        }

        public string getInfo() {
            return $"Rocket {Name} with power: {Power}, start mass: {Mass}.";
        
        }

    }
}
