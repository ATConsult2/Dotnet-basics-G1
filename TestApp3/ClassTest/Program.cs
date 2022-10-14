using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using andestech.learning2022.krasn.rocketplant;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rocket rocket = new Rocket();
            rocket.Power = 10000000;
            rocket.Name = "Vostok";
            rocket.Mass = 12312344;

            WriteLine(rocket.getInfo());

            Rocket rocket2 = new Rocket() {Mass=1000_000, Power=100000, Name="Energy" };
            WriteLine(rocket2.getInfo());

            Rocket2 rocket21 = new Rocket2() 
            { Mass = 1000_000, Power = 78101010, Name = "Soyuz" };
            WriteLine(rocket21.getInfo());

            Rocket3 rocket31 = new Rocket3("Soyuz", 26363636, 1000_000);
            //{ Mass = 1000_000, Power = 78101010, Name = "Soyuz" };
            WriteLine(rocket31.getInfo());

            Rocket4 rocket41 = new Rocket4("Astra", 2227777, 7000_000);
            WriteLine(rocket41.getInfo());
        }
    }
}
