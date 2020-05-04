using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaratayudaWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Duryudono duryudono = new Duryudono();
            Dursosono dursosono = new Dursosono();
            Karna karna = new Karna();
            Bima bima = new Bima();

            duryudono.hit();
            dursosono.kick();
            karna.defend();
            bima.dead();
        }
    }
}
