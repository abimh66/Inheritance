using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreetRacer streetRacer = new StreetRacer();
            FormulaOne formulaOne = new FormulaOne();
            Helicopter helicopter = new Helicopter();


            streetRacer.go();
            formulaOne.go();
            helicopter.gogo();


        }
    }
}
