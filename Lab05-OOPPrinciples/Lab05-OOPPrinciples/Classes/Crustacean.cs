using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inheriting Animal class
    public class Crustacean : Animal, ISwim
    {
        public bool LivesInWater { get; set; }
        public bool Exoskeleton { get; set; }
        public string Swim
        {
            get
            {
                return "Splashhhh!";
            }
            set
            {

            }
        }    

        public virtual string BeEaten()
        {
            return "Crustaceans are food for humans!";
        }
    }
}
