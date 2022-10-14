using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.rocketplant
{
    class Rocket4
    {
        /* private string _name;
         private double _mass;
         private double _power;   */

        public const string ROCKETFACTORY = "AAA111-BBB-ZZ";
        public static readonly long ID = generateId();
    
        public string Name  { get; } // readonly auto property
        public double Mass  { get; private set; }  
        public double Power { get; private set; } 
       
        //.....
        public Rocket4() {
            WriteLine("+++ ctor default of Rocket3");
        }

        public Rocket4(string Name, double Power, double Mass):this()
        {
            WriteLine("+++ ctor params of Rocket3");
            this.Name = Name;
            this.Mass = Mass;
            this.Power = Power;

        }

        private static long generateId() {
            return new Random().Next(1_000_000_000);
            //Name = "aaaa";  // readonly!!!
        }

        public void addPower(double add) { Power += add; }

        public string getInfo() {
            return $"Rocket {Name} with power: {Power}, start mass: {Mass}.";
        
        }

    }
}
