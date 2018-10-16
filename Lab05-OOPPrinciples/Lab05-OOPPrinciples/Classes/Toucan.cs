using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inherits TropicalBird class
    class Toucan : TropicalBird
    {
        public bool NamedSam { get; set; }
        public bool EatsCereal { get; set; }

        public override string TropicalHabitat { get; set; } = "I don't live in the Amazon!";
        public override bool ColorfulPlumage { get; set; } = false;


        // Virtual method from Aviary that Toucan is overriding
        public override string Fly()
        {
            return "I cannot fly!";
        }
    }


}
