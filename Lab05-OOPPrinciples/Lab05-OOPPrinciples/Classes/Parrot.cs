using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inherits TropicalBird class
    public class Parrot : TropicalBird
    {
        public int PirateFriends { get; set; }
        public bool RedPlummage { get; set; }

        public override string TropicalHabitat { get; set; } = "I live in the Amazon!";
        public override bool ColorfulPlumage { get; set; } = true;
    }
}
