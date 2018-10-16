using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inheriting Animal class
    public class Crustacean : Animal
    {
        public bool LivesInWater { get; set; }
        public bool Exoskeleton { get; set; }

        public virtual string BeEaten()
        {
            return "I am food for humans!";
        }
    }
}
