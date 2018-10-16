using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inheriting Feline class
    public class Jaguar : Feline
    {
        public bool SpotsOnCoat { get; set; }
        public string JungleHabitat { get; set; }

        public override string Bites()
        {
            return "Jaguars bite!";
        }

        public override string Cry()
        {
            return "Jaguars roar to cry.";
        }
    }
}
