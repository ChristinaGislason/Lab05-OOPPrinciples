using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inherits Shrimp class
    public class Krill : Shrimp
    {
        public bool WhaleFood { get; set; }
        public bool TinySize { get; set; }

        // Virtual method from Crustacean that Krill is overriding
        public override string BeEaten()
        {
            return "I am food for whales!";
        }
    }
}
