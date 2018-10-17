using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inherits TropicalBird class
    public class Toucan : TropicalBird
    {
        public bool NamedSam { get; set; }
        public bool EatsCereal { get; set; }

        public override string TropicalHabitat { get; set; } = "Toucans don't live in the Amazon!";
        public override bool ColorfulPlumage { get; set; } = false;


        // Virtual method from Aviary that Toucan is overriding
        public override string Fly()
        {
            return "Toucans cannot fly!";
        }
    }


}
