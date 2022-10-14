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
        }
    }
}
