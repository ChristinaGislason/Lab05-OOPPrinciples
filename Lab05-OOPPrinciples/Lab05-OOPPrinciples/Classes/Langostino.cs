using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inherits Shrimp class
    public class Langostino : Shrimp
    {
        public bool GreatInPasta { get; set; }
        public int Antennae { get; set; } = 2;

        // Virtual property from Shrimp that langostino overrides
        public override int Legs { get; set; } = 10;

    }
}
